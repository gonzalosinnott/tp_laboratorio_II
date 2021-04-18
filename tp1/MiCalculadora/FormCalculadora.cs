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
        /// <summary>
        /// Inicializa el Formulario
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ejecuta el metodo operar al clickear el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = this.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
        }
        /// <summary>
        /// Metodo Operar
        /// </summary>
        /// <param name="numero1">Numero Uno</param>
        /// <param name="numero2">Numero Dos</param>
        /// <param name="operador">Operador Matematico</param>
        /// <returns>Operacion matematica de los parametros dados</returns>
        private double Operar(string numero1, string numero2, string operador)
        {
            Numero numeroUno = new Numero();
            Numero numeroDos = new Numero();
            numeroUno.SetNumero = numero1.Replace(".", ",");
            numeroDos.SetNumero = numero2.Replace(".", ",");

            return Calculadora.Operar(numeroUno, numeroDos, operador);
        }
        /// <summary>
        /// Ejecuta el metodo decimal a binario al clickear el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero resultado = new Numero();
            lblResultado.Text = resultado.DecimalBinario(lblResultado.Text.Replace(".", ","));
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }
        /// <summary>
        /// Ejecuta el metodo binario a decimal al clickear el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero resultado = new Numero();
            lblResultado.Text = resultado.BinarioDecimal(lblResultado.Text);
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }
        /// <summary>
        /// Cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Ejecuta el metodo limpiar al clickear el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }
        /// <summary>
        /// Limpia de datos el formulario
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperador.SelectedItem = null;
            lblResultado.Text = "";
        }
    }
}
