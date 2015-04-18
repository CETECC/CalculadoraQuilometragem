using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraQuilometragem
{
    public partial class Form1 : Form
    {
        private int kmInicial;
        private int kmFinal;
        private double totalDevido;
        private double kmViajados;
        private double taxaReembolso = 0.39;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            kmInicial = (int)numInicial.Value;
            kmFinal = (int)numFinal.Value;

            if (kmInicial > kmFinal)
            {
                MessageBox.Show("A Quilometragem inicial não pode ser maior que a quilometragem final.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            kmViajados = kmFinal - kmInicial;
            totalDevido = kmViajados * taxaReembolso;

            lblResultado.Text = totalDevido.ToString("C");
        }
    }
}
