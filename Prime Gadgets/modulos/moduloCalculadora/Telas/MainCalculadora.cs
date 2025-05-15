using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prime_Gadgets.modulos.moduloSenhas;

namespace Prime_Gadgets.modulos.moduloCalculadora.Telas
{
    public partial class MainCalculadora : Form
    {
        public MainCalculadora()
        {
            InitializeComponent();
        }

        private void btMainCalculadoraReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btMainCalculadoraHistory_Click(object sender, EventArgs e)
        {
            HistoricoCalculadora historicoCalculadora = new HistoricoCalculadora();
            historicoCalculadora.ShowDialog();
        }

        private void btMainCalculadoraOntop_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
                btMainCalculadoraOntop.Text = "On top";
            }
            else
            {
                this.TopMost = true;
                btMainCalculadoraOntop.Text = "Off top";
            }
        }

        private void btMainCalculadoraPaste_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadoraConversor_Click(object sender, EventArgs e)
        {
            ConversorCalculadora conversorCalculadora = new ConversorCalculadora();
            conversorCalculadora.ShowDialog();
        }

        private void btMainCalculadoraSum_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadoraSubtraction_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadoraMultiplication_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadoraDivision_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadora0_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadora1_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadora2_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadora3_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadora4_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadora5_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadora6_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadora7_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadora8_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadora9_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadoraComma_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadoraClear_Click(object sender, EventArgs e)
        {

        }

        private void btMainCalculadoraEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
