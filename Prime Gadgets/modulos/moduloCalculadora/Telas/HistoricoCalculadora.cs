using System;
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
    public partial class HistoricoCalculadora : Form
    {
        public string ContaSelecionada { get; private set; }

        public HistoricoCalculadora()
        {
            InitializeComponent();
        }

        private void btHistoricoCalculadoraVoltar_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            telaAtual.Close();
        }
        public void AtualizarListBox()
        {
            var acesso = new CalculadoraAccess();
            var contas = acesso.LerHistorico();

            libHistoricoCalculadoraArm.Items.Clear();
            foreach (var conta in contas)
            {
                libHistoricoCalculadoraArm.Items.Add($"{conta.Numero1} {conta.Operador} {conta.Numero2} = {conta.Resultado}");
            }
        }


        private void btHistoricoCalculadoraClear_Click(object sender, EventArgs e)
        {
            var acesso = new CalculadoraAccess();
            acesso.DeleteHistorico(0);
            libHistoricoCalculadoraArm.Items.Clear();
        }

        private void HistoricoCalculadora_Load(object sender, EventArgs e)
        {
            AtualizarListBox();
        }
        private void libHistoricoCalculadoraArm_DoubleClick(object sender, EventArgs e)
        {
            if (libHistoricoCalculadoraArm.SelectedItem != null)
            {
                ContaSelecionada = libHistoricoCalculadoraArm.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
