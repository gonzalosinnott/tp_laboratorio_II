using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using MaterialSkin.Controls;
using Entidades;
using System.Linq;
using System.Diagnostics;


namespace GUI
{
    
    public partial class frmMain : MaterialForm
    {

        Factory miFabrica = new Factory();
        string partsPathXml = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/XMLParts.xml";
        string productsPathXml = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/XMLProducts.xml";
        string partsPathPdf = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/PDFParts.pdf";
        string productsPathPdf = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/PDFProducts.pdf";

        public frmMain()
        {
            InitializeComponent();
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

            catch (Exception)
            {
                MessageBox.Show($"ERROR AL ABRIR BASE DE DATOS.\nRevise la existencia del archivo y vuelva a abrir el programa.", "Error", MessageBoxButtons.OK);
            }

            refreshGrids();
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
            rtbGuitarsInfo.Text = miFabrica.ProductsInfo();

            dgvPieces.ClearSelection();
            dgvWood.ClearSelection();
            dgvPickups.ClearSelection();
            dgvElectronics.ClearSelection();
            dgvTuners.ClearSelection();
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
                refreshGrids();
            }
        }

        /// <summary>
        /// Borra un objeto de la lista del stock de piezas
        /// </summary>
        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPieces.CurrentRow.Selected != false)
                {
                    Part part = dgvPieces.CurrentRow.DataBoundItem as Part;
                    miFabrica.removePart(dgvPieces.CurrentRow.Index);
                    miFabrica.DeleteDB(part.Id);
                    refreshGrids();
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

        }

        /// <summary>
        /// Crea un objeto de la lista de productos
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {

            try
            {

                if (this.cmbGuitarModel.SelectedItem == null || this.cmbGuitarModel.SelectedIndex == -1)
                {
                    MessageBox.Show("SELECCIONE UN MODELO DE GUITARRA A FABRICAR", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if (dgvWood.CurrentRow.Selected != false &&
                        dgvPickups.CurrentRow.Selected != false &&
                        dgvElectronics.CurrentRow.Selected != false &&
                        dgvTuners.CurrentRow.Selected != false)
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
                        refreshGrids();
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

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "¿DESEA SALIR";
            const string caption = "";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }        

        private void btnPartsReportXml_Click(object sender, EventArgs e)
        {
            pbPartXml.Value = 0;
            Thread thread = new Thread(() => SaveDocumentProgress(pbPartXml));
            thread.Start();

            try
            {
                miFabrica.CreateXml(partsPathXml, miFabrica.PartsList);
            }
            catch (Exception)
            {
                MessageBox.Show($"ERROR AL GUARDAR EL ARCHIVO EN {partsPathXml}", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                pbPartXml.Value = 0;
            }
        }

        private void btnProductsReportXml_Click(object sender, EventArgs e)
        {
            pbProductXml.Value = 0;
            Thread thread = new Thread(() => SaveDocumentProgress(pbProductXml));
            thread.Start();

            try
            {
                miFabrica.CreateXml(productsPathXml, miFabrica.GuitarsList);
            }
            catch (Exception)
            { 
               MessageBox.Show($"ERROR AL GUARDAR EL ARCHIVO EN {productsPathXml}", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                pbProductXml.Value = 0;
            }
        }

        private void btnProductsReportPdf_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => SaveDocumentProgress(pbProductPdf));
            thread.Start();

            try
            {
                miFabrica.CreatePdf(miFabrica.ProductsInfo(), productsPathPdf);
            }
            catch (Exception)
            {
                MessageBox.Show($"ERROR AL GUARDAR EL ARCHIVO EN {productsPathPdf}\nASEGURESE DE QUE EL ARCHIVO NO SE ENCUENTRE ABIERTO", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                pbProductPdf.Value = 0;
            }
        }

        private void btnPartsReportPdf_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => SaveDocumentProgress(pbPartPdf));
            thread.Start();

            try
            {
                miFabrica.CreatePdf(miFabrica.PartsInfo(), partsPathPdf);

            }
            catch (Exception)
            {
                MessageBox.Show($"ERROR AL GUARDAR EL ARCHIVO EN {partsPathPdf}\nASEGURESE DE QUE EL ARCHIVO NO SE ENCUENTRE ABIERTO", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                pbPartPdf.Value = 0;                
            }
        }       

        private void SaveDocumentProgress(ProgressBar bar)
        {
            int done = 0;
            if(bar.InvokeRequired)
            {
                bar.BeginInvoke((MethodInvoker)delegate ()
                {
                    while (done < 100)
                    {
                        done += 1;
                        Thread.Sleep(25);
                        if (done > bar.Value)
                        {
                            bar.Value = done;
                        }
                    }
                }
                );
            }
            else
            {
                while (done < 100)
                {
                    done += 1;
                    Thread.Sleep(25);
                    if (done > bar.Value)
                    {
                        bar.Value = done;
                    }
                }
            }            
        }

        private void openFile(string path)
        {
            try
            {
                Process.Start(path);
            }
            catch (Exception)
            {
                MessageBox.Show($"ERROR AL ABRIR EL ARCHIVO EN {path}\nARCHIVO INEXISTENTE", "Error", MessageBoxButtons.OK);
            }
        }

        private void openProductsPdf_Click(object sender, EventArgs e)
        {
            openFile(productsPathPdf);
        }

        private void openPartsPdf_Click(object sender, EventArgs e)
        {
            openFile(partsPathPdf);
        }

        private void openPartsXml_Click(object sender, EventArgs e)
        {
            openFile(partsPathXml);
        }

        private void openProductsXml_Click(object sender, EventArgs e)
        {
            openFile(productsPathXml);
        }
    }
}
