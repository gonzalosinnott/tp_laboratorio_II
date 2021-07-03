using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using Entidades;
using System.Xml.Serialization;
using System.Xml;
using System.Linq;
using System.Linq.Expressions;
using System.IO;

namespace GUI
{

    public partial class frmMain : MaterialForm
    {

        Factory miFabrica = new Factory();
        string partsPath = AppDomain.CurrentDomain.BaseDirectory + "XMLParts.xml";
        string guitarsPath = AppDomain.CurrentDomain.BaseDirectory + "XMLGuitars.xml";

        public frmMain()
        {
            InitializeComponent();

            Factory miFabrica = new Factory();

            dgvPieces.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "id",
                DataPropertyName = "Id",
                HeaderText = "ID"
            });

            dgvPieces.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "classType",
                DataPropertyName = "ClassType",
                HeaderText = "PIEZA"
            });            

            dgvPieces.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "type",
                DataPropertyName = "Type",
                HeaderText = "TIPO"
            });

            dgvPieces.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "manufacturer",
                DataPropertyName = "Manufacturer",
                HeaderText = "FABRICANTE"
            });

            dgvPieces.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "entryDate",
                DataPropertyName = "EntryDate",
                HeaderText = "INGRESO"
            });
        }
        /// <summary>
        /// Actualiza los valores de los datagrids del form
        /// </summary>
        private void refreshGrids()
        {
            dgvPieces.DataSource = miFabrica.PartsList.ToList();
            dgvWood.DataSource = miFabrica.PartsList.OfType<Wood>().ToList();
            dgvPickups.DataSource = miFabrica.PartsList.OfType<Pickup>().ToList(); ;
            dgvElectronics.DataSource = miFabrica.PartsList.OfType<Electronics>().ToList();
            dgvTuners.DataSource = miFabrica.PartsList.OfType<Tuners>().ToList();
            rtbGuitarsInfo.Text = miFabrica.StockInfo();
            
            dgvPieces.ClearSelection();
            dgvWood.ClearSelection();
            dgvPickups.ClearSelection();
            dgvElectronics.ClearSelection();
            dgvTuners.ClearSelection();           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tbMain.Enabled = false;
            tbMain.SelectTab(0);
            
            try
            {
                miFabrica.OpenDB();
                tbMain.Enabled = true;
            }
            
            catch(Exception)
            {
                MessageBox.Show($"ERROR AL ABRIR BASE DE DATOS.\nRevise la existencia del archivo y vuelva a abrir el programa.", "Error", MessageBoxButtons.OK);
            }

            refreshGrids();
        }
       
        /// <summary>
        /// Guarda los datos del datagrid correspondiente al stock de piezas en un archivo xml
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {            
                miFabrica.SavePartsFile(partsPath);
                MessageBox.Show($"CAMBIOS GUARDADOS CON EXITO en {partsPath}", "", MessageBoxButtons.OK);            
        }
        /// <summary>
        /// Maneja las posibles opciones que puede elegir el usuario en el form de ingreso de stock
        /// a paritr del tipo de pieza que pretende ingresar
        /// </summary>
        private void cmbPieceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCustomType.Enabled = true;
            cmbManufacturer.Enabled = true;
            string[] emptyComboBox = new[] { "N/A" };

            switch (cmbPieceType.SelectedIndex)
            {
                case 0:
                    cmbCustomType.DataSource = emptyComboBox;
                    cmbCustomType.Enabled = false;
                    cmbManufacturer.DataSource = Enum.GetNames(typeof(TunersMakers));
                    break;
                case 1:
                    cmbManufacturer.DataSource = emptyComboBox; ;
                    cmbManufacturer.Enabled = false;
                    cmbCustomType.DataSource = Enum.GetNames(typeof(ElectronicType));
                    break;
                case 2:
                    cmbManufacturer.DataSource = emptyComboBox;
                    cmbManufacturer.Enabled = false;
                    cmbCustomType.DataSource = Enum.GetNames(typeof(WoodType));
                    break;
                case 3:
                    cmbCustomType.DataSource = Enum.GetNames(typeof(PickupsType));
                    cmbManufacturer.DataSource = Enum.GetNames(typeof(PickupsMaker));
                    break;
                
            }
        }       
        /// <summary>
        /// Agrega un objeto a la lista de stock de piezas
        /// </summary>
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (this.cmbPieceType.SelectedItem == null || this.cmbPieceType.SelectedIndex == -1)
            {
                MessageBox.Show("ASEGURESE DE COMPLETAR TODOS LOS CAMPOS", "Error", MessageBoxButtons.OK);
            }
            else
            {
                miFabrica.AddPart(cmbPieceType.Text, cmbCustomType.Text, cmbManufacturer.Text);
            }      

            refreshGrids();
        }

        /// <summary>
        /// Borra un objeto de la lista del stock de piezas
        /// </summary>
        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPieces.CurrentCell.Selected != false)
                {
                    Part part = dgvPieces.CurrentRow.DataBoundItem as Part;
                    miFabrica.removePart(dgvPieces.CurrentRow.Index);
                    miFabrica.DeleteDB(part.Id); 
                }
                else
                {
                    MessageBox.Show($"SELECCIONE UN ITEM A ELIMINAR DEL STOCK", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("NO HAY ITEMS PARA ELIMINAR", "Error", MessageBoxButtons.OK);
            }
            refreshGrids();

        }
        /// <summary>
        /// Crea un objeto de la lista de productos
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {

            try
            {
               
                if(this.cmbGuitarModel.SelectedItem == null || this.cmbGuitarModel.SelectedIndex == -1)
                {
                    MessageBox.Show("SELECCIONE UN MODELO DE GUITARRA A FABRICAR", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if (dgvWood.CurrentCell.Selected != false &&
                        dgvPickups.CurrentCell.Selected != false &&
                        dgvElectronics.CurrentCell.Selected != false &&
                        dgvTuners.CurrentCell.Selected != false)
                    {
                        Wood wood = dgvWood.CurrentRow.DataBoundItem as Wood;
                        Pickup pickup = dgvPickups.CurrentRow.DataBoundItem as Pickup;
                        Electronics electronic = dgvElectronics.CurrentRow.DataBoundItem as Electronics;
                        Tuners tuners = dgvTuners.CurrentRow.DataBoundItem as Tuners;

                        miFabrica.AddGuitar(wood.Data(), pickup.Data(), electronic.Data(), tuners.Data(), cmbGuitarModel.Text); 
                        
                        miFabrica.removePart(dgvWood.CurrentRow.Index);
                        miFabrica.removePart(dgvPickups.CurrentRow.Index);
                        miFabrica.removePart(dgvElectronics.CurrentRow.Index);
                        miFabrica.removePart(dgvTuners.CurrentRow.Index);

                        miFabrica.DeleteDB(wood.Id);
                        miFabrica.DeleteDB(pickup.Id);
                        miFabrica.DeleteDB(electronic.Id);
                        miFabrica.DeleteDB(tuners.Id);
                    }
                    else
                    {
                        MessageBox.Show($"ASEGURESE DE SELECCIONAR TODOS LOS\nMATERIALES DE LA LISTA DE MATERIALES.", "Error", MessageBoxButtons.OK);

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("STOCK DE MATERIALES INSUFICIENTES", "Error", MessageBoxButtons.OK);
            }

             refreshGrids();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "¿DESEA SALIR";
            const string caption = "";
            var result = MessageBox.Show(message, caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
