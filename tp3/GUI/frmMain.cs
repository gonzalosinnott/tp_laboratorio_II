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
        string partsPath = AppDomain.CurrentDomain.BaseDirectory + @"\XMLParts.xml";
        string guitarsPath = AppDomain.CurrentDomain.BaseDirectory + @"\XMLGuitars.xml";
        string pathDestinationParts = AppDomain.CurrentDomain.BaseDirectory + @"\XMLParts.xml";
        string pathStyle = AppDomain.CurrentDomain.BaseDirectory + @"\Style.xml";


        public frmMain()
        {
            InitializeComponent();

            Factory miFabrica = new Factory();

            dgvPieces.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "classType",
                DataPropertyName = "ClassType",
                HeaderText = "PIEZA"
            });

            dgvPieces.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "name",
                DataPropertyName = "Name",
                HeaderText = "NOMBRE"
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
                HeaderText = "FECHA DE INGRESO"
            });

            dgvPieces.DataSource = miFabrica.PartsList;
            dgvGuitars.DataSource = miFabrica.GuitarsList;

            refreshGrids();
            
        }
        /// <summary>
        /// Actualiza los valores de los datagrids del form
        /// </summary>
        private void refreshGrids()
        {
            dgvPieces.DataSource = miFabrica.PartsList.ToList();
            dgvGuitars.DataSource = miFabrica.GuitarsList.ToList();
            dgvWood.DataSource = miFabrica.PartsList.OfType<Wood>().ToList();
            dgvPickups.DataSource = miFabrica.PartsList.OfType<Pickup>().ToList(); ;
            dgvElectronics.DataSource = miFabrica.PartsList.OfType<Electronics>().ToList();
            dgvTuners.DataSource = miFabrica.PartsList.OfType<Tuners>().ToList();

            dgvPieces.ClearSelection();
            dgvWood.ClearSelection();
            dgvPickups.ClearSelection();
            dgvElectronics.ClearSelection();
            dgvTuners.ClearSelection();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tbMain.Enabled = false;
            btnSave.Enabled = false;
            tbMain.SelectTab(0);
            
            try
            {
                if (miFabrica.OpenPartsFile(partsPath) == true)
                {
                    tbMain.Enabled = true;
                    btnSave.Enabled = true;
                }
            }
            
            catch(Exception)
            {
                MessageBox.Show($"ERROR AL ABRIR EL ARCHIVO EN LA RUTA {partsPath}.\nRevise la existencia del archivo y vuelva a abrir el programa.", "Error", MessageBoxButtons.OK);
            }

            try
            {
                miFabrica.OpenGuitarsFile(guitarsPath);
            }
            catch (Exception)
            {
                MessageBox.Show($"ERROR AL ABRIR EL ARCHIVO EN LA RUTA {guitarsPath}.\n Fabrique una guitarra para crear el archivo.", "Error", MessageBoxButtons.OK);
            }

            refreshGrids();
            dgvGuitars.DataSource = miFabrica.GuitarsList.ToList();
        }
       
        /// <summary>
        /// Guarda los datos del datagrid correspondiente al stock de piezas en un archivo xml
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                miFabrica.SavePartsFile(partsPath);
                MessageBox.Show($"CAMBIOS GUARDADOS CON EXITO en {partsPath}", "", MessageBoxButtons.OK);

            }
            catch (Exception)
            {
               MessageBox.Show($"ERROR AL GUARDAR EL ARCHIVO EN LA RUTA {partsPath}.los cambios no han podido ser guardados\n", "Error", MessageBoxButtons.OK);
            }
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
            
            try
            {
                miFabrica.AddPart(cmbPieceType.Text, txtName.Text, cmbCustomType.Text, dtpDateStock.Value.Date, cmbManufacturer.Text);
                refreshGrids();
            }
            catch (Exception)
            {
                MessageBox.Show("ASEGURESE DE COMPLETAR TODOS LOS CAMPOS", "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Borra un objeto de la lista del stock de piezas
        /// </summary>
        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            if(dgvPieces.CurrentRow != null)
            {
                miFabrica.removePart(dgvPieces.CurrentRow.Index);
                refreshGrids();

            }
        }        
        /// <summary>
        /// Crea un objeto de la lista de productos
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {

            try
            {
                miFabrica.AddGuitar(dgvWood.CurrentRow.Cells.ToString(), dgvPickups.CurrentRow.DataBoundItem.ToString(), dgvElectronics.CurrentRow.DataBoundItem.ToString(), dgvTuners.CurrentRow.DataBoundItem.ToString(), cmbGuitarModel.Text, dtpDateGuitars.Value.Date);

                miFabrica.removePart(dgvWood.CurrentRow.Index);
                miFabrica.removePart(dgvPickups.CurrentRow.Index);
                miFabrica.removePart(dgvElectronics.CurrentRow.Index);
                miFabrica.removePart(dgvTuners.CurrentRow.Index);

                refreshGrids();
            }
            catch (Exception)
            {
                MessageBox.Show("ASEGURESE DE TENER EL STOCK DE MATERIALES NECESARIO", "Error", MessageBoxButtons.OK);
            }

            try
            {
                miFabrica.SaveGuitarsFile(guitarsPath);
            }
            catch(Exception)
            {
                MessageBox.Show($"FALLO ALGO A LA HORA DE GUARDAR EL ARCHIVO EN LA RUTA {guitarsPath}", "Error", MessageBoxButtons.OK);

            }

        }

        /// <summary>
        /// Genera un archivo HTML a partir del xml dado
        /// </summary>
        private void btnStockReport_Click(object sender, EventArgs e)
        {
            string pathOrigin = AppDomain.CurrentDomain.BaseDirectory + "XMLParts.xml";
            
            try
            {
                FilesConfig.MakeHTML(partsPath, pathDestinationParts, pathStyle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
