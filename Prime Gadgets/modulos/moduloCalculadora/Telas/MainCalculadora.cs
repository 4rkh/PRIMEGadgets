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
            if(this.TopMost)
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
    }
}
