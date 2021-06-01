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

namespace GUI
{
    public partial class frmMain : MaterialForm
    {
        public frmMain()
        {
            InitializeComponent();

            /*Paleta de Colores
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800,
                                                                           MaterialSkin.Primary.BlueGrey900,
                                                                           MaterialSkin.Primary.BlueGrey500,
                                                                           MaterialSkin.Accent.LightBlue200,
                                                                           MaterialSkin.TextShade.WHITE);
            */
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlPieceProperties.BackColor = Color.FromArgb(0, 0, 0, 0);
        }
    }
}
