using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = this.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
        }

        private double Operar(string numero1, string numero2, string operador)
        {
            Numero numeroUno = new Numero();
            Numero numeroDos = new Numero();
            numeroUno.SetNumero = numero1.Replace(".", ",");
            numeroDos.SetNumero = numero2.Replace(".", ",");

            return Calculadora.Operar(numeroUno, numeroDos, operador);
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero resultado = new Numero();
            lblResultado.Text = resultado.DecimalBinario(lblResultado.Text.Replace(".", ","));
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero resultado = new Numero();
            lblResultado.Text = resultado.BinarioDecimal(lblResultado.Text);
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
        }

        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperador.SelectedItem = null;
            lblResultado.Text = "";
        }

        
    }
}
