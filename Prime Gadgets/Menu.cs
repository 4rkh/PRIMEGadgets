using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prime_Gadgets.modulos.moduloContatos;
using Prime_Gadgets.modulos.moduloCalendario;
using Prime_Gadgets.modulos.moduloSenhas;
using Prime_Gadgets.modulos.moduloCalculadora.Telas;

namespace Prime_Gadgets
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            if (telaAtual is TelaPrincipal)
            {
                return;
            }
            TelaPrincipal mainPrincipal = new TelaPrincipal();
            mainPrincipal.FormClosed += (s, args) => telaAtual.Close();
            mainPrincipal.Show();
            telaAtual.Hide();
        }

        private void btCalculadora_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            MainCalculadora mainCalculadora = new MainCalculadora();
            mainCalculadora.FormClosed += (s, args) => telaAtual.Close();
            mainCalculadora.Show();
            telaAtual.Hide();
        }

        private void btContatos_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            if (telaAtual is MainContato)
            {
                return;
            }
            MainContato mainContatos = new MainContato();
            mainContatos.FormClosed += (s, args) => telaAtual.Close();
            mainContatos.Show();
            telaAtual.Hide();
        }

        private void btCalendario_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            if (telaAtual is MainCalendario)
            {
                return;
            }
            MainCalendario mainCalendario = new MainCalendario();
            mainCalendario.FormClosed += (s, args) => telaAtual.Close();
            mainCalendario.Show();
            telaAtual.Hide();
        }

        private void btSenhas_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            if (telaAtual is MainSenhas)
            {
                return;
            }
            MainSenhas mainSenhas = new MainSenhas();
            mainSenhas.FormClosed += (s, args) => telaAtual.Close();
            mainSenhas.Show();
            telaAtual.Hide();
            }
        }
    }