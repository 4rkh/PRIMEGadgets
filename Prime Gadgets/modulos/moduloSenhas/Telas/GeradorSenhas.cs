using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloSenhas
{
    public partial class GeradorSenhas : Form
    {
        public GeradorSenhas()
        {
            InitializeComponent();
        }

        private void btGeradorSenhasCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btGeradorSenhasSalvar_Click(object sender, EventArgs e)
        {
            SenhaConfig.comprimento = tbGeradorSenhasComprimento.Value;
            SenhaConfig.letraMa = cbGeradorSenhasLetrasMa.Checked;
            SenhaConfig.letraMi = cbGeradorSenhasLetrasMi.Checked;
            SenhaConfig.CaracterEs = cbGeradorSenhasCaracterEs.Checked;
            this.Dispose();
        }

        private void tbGerarSenhasComprimento_Scroll(object sender, EventArgs e)
        {
            lbGeradorSenhasComprimentoNumber.Text = tbGeradorSenhasComprimento.Value.ToString();
        }
    }
}
