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
    public partial class frmQltyCtrl : MaterialForm
    {
        public frmQltyCtrl()
        {
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
