using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using Entidades;
using SerializationAndFiles;

namespace GUI
{
    public partial class frmMain : MaterialForm
    {
        
        public frmMain()
        {
            InitializeComponent();
            Factory miFabrica = new Factory();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tbMain.Enabled = false;
            tbMain.SelectTab(0);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            tbMain.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ///SerializationAndFiles.XmlSerializer<Factory>.Save(@"..\files\file.xml", Factory.partsList);
        }

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
       

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            
            try
            {
                Factory.AddPart(cmbPieceType.Text, txtName.Text, cmbCustomType.Text, dtpDate.Value.Date, cmbManufacturer.Text);
                dgvPieces.DataSource = Factory.PartsList.ToList();
            }
            catch(Exception)
            {
                MessageBox.Show("ASEGURESE DE COMPLETAR TODOS LOS CAMPOS", "Error", MessageBoxButtons.OK);
            }
            

        }

        private void btnRecallStock_Click(object sender, EventArgs e)
        {
            ShowQltyForm();
        }

        private void btnRecallProduct_Click(object sender, EventArgs e)
        {
            ShowQltyForm();
        }

        private void ShowQltyForm()
        {
            frmQltyCtrl form = new frmQltyCtrl();
            form.ShowDialog();
        }

        private void ShowError()
        {
            MessageBox.Show("ASEGURESE DE COMPLETAR TODOS LOS CAMPOS", "Error", MessageBoxButtons.OK);
        }

      

        
    }
}
