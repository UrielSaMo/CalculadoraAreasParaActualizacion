using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraAreasParaActualizacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelRombo.Visible = false;
            panelRomboide.Visible = false;
        }

        private void buttonRombo_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelRombo);
        }

        private void buttonRomboide_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelRomboide);
        }
        private void MostrarPanel(Panel panelSeleccionado)
        {
            // Oculta todos los paneles
            panelRomboide.Visible = false;
            panelRombo.Visible = false;

            // Muestra el panel seleccionado
            panelSeleccionado.Visible = true;
        }

        private void buttonCalcularRombo_Click(object sender, EventArgs e)
        {
            double baseT, altura, res;

            string texto = textBoxDiametroM.Text;
            string texto2 = textBoxDiametroMenor.Text;

            bool NumeroValido = double.TryParse(textBoxDiametroM.Text, out baseT);
            bool NumeroValido2 = double.TryParse(textBoxDiametroMenor.Text, out altura);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$") && Regex.IsMatch(texto2, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido && NumeroValido2)
                {
                    baseT = double.Parse(textBoxDiametroM.Text);
                    altura = double.Parse(textBoxDiametroMenor.Text);
                    res = (baseT * altura) / 2;
                    textBoxResultadoRombo.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }
        }

        private void buttonCalcularRomboide_Click(object sender, EventArgs e)
        {
            double baseT, altura, res;

            string texto = textBoxBaseR.Text;
            string texto2 = textBoxAlturaR.Text;

            bool NumeroValido = double.TryParse(textBoxBaseR.Text, out baseT);
            bool NumeroValido2 = double.TryParse(textBoxAlturaR.Text, out altura);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$") && Regex.IsMatch(texto2, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido && NumeroValido2)
                {
                    baseT = double.Parse(textBoxBaseR.Text);
                    altura = double.Parse(textBoxAlturaR.Text);
                    res = baseT * altura;
                    textBoxResultadoRomboide.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }
        }
    }
}
