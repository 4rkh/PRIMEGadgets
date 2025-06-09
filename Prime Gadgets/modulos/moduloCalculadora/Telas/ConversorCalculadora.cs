using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloCalculadora
{
    public partial class ConversorCalculadora : Form
    {
        public ConversorCalculadora()
        {
            InitializeComponent();
            cbConversorCalculadoraTipo.DataSource = Conversor.TiposConversao;
            cbConversorCalculadoraTipo.DisplayMember = "Texto";
            cbConversorCalculadoraTipo.ValueMember = "Valor";
        }


        private void btConversorCalculadoraCancelar_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            telaAtual.Close();
        }

        private void btConversorCalculadoraConverter_Click(object sender, EventArgs e)
        {

        }

        private void cbConversorCalculadoraTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var conversor = cbConversorCalculadoraTipo.SelectedItem as Conversor;
            if (conversor.Valor == 0)
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.ConversaoBloqueada;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.ConversaoBloqueada;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = false;
                cbConversorCalculadoraUnidade2.Enabled = false;
            } else if (conversor.Valor == 1)
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipoT1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoT2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
                cbConversorCalculadoraUnidade2.Enabled = true;
            } else if (conversor.Valor == 2)
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipoD1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoD2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
                cbConversorCalculadoraUnidade2.Enabled = true;
            }
            else if (conversor.Valor == 3)
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipoC1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoC2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
                cbConversorCalculadoraUnidade2.Enabled = true;
            }

        }
    }
}
