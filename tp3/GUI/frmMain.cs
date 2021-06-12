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

namespace GUI
{
    public partial class frmMain : MaterialForm
    {
        public frmMain()
        {
            InitializeComponent();            
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
            tbMain.Enabled = false;
        }

        private void cmbPieceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCustomType.Enabled = true;
            cmbManufacturer.Enabled = true;

            switch (cmbPieceType.SelectedIndex)
            {
                case 0:
                    cmbCustomType.DataSource = null;
                    cmbCustomType.Enabled = false;
                    cmbManufacturer.DataSource = Enum.GetNames(typeof(TunersMakers));
                    break;
                case 1:
                    cmbManufacturer.DataSource = null;
                    cmbManufacturer.Enabled = false;
                    cmbCustomType.DataSource = Enum.GetNames(typeof(ElectronicType));
                    break;
                case 2:
                    cmbManufacturer.DataSource = null;
                    cmbManufacturer.Enabled = false;
                    cmbCustomType.DataSource = Enum.GetNames(typeof(WoodType));
                    break;
                case 3:
                    cmbCustomType.DataSource = Enum.GetNames(typeof(PickupsType));
                    cmbManufacturer.DataSource = Enum.GetNames(typeof(PickupsMaker));
                    break;
                case 4:
                    cmbManufacturer.DataSource = null;
                    cmbManufacturer.Enabled = false;
                    cmbCustomType.DataSource = Enum.GetNames(typeof(TremoloType));
                    break;
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

    }
}
