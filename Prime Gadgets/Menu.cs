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
using Prime_Gadgets.modulos.moduloCalculadora;
using Prime_Gadgets.modulos.moduloHome;

namespace Prime_Gadgets
{
    public partial class Menu : UserControl
    {
        private static MainCalculadora instanciaCalc = null;
        public Menu()
        {
            InitializeComponent();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            if (telaAtual is MainHome)
            {
                return;
            }
            MainHome homeTela = new MainHome();
            homeTela.Dock = DockStyle.Fill;
            homeTela.TopLevel = false;
            TelaPrincipal.mainPanel.Controls.Clear();
            TelaPrincipal.mainPanel.Controls.Add(homeTela);
            homeTela.Show();
        }

        private void btCalculadora_Click(object sender, EventArgs e)
        {
            if (instanciaCalc == null || instanciaCalc.IsDisposed)
            {
                instanciaCalc = new MainCalculadora();
                instanciaCalc.FormClosed += (s, args) => instanciaCalc = null;
                instanciaCalc.Show();
            }
            else
            {
                instanciaCalc.BringToFront();
                instanciaCalc.WindowState = FormWindowState.Normal;
            }
        }

        private void btContatos_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            if (telaAtual is MainContato)
            {
                return;
            }
            MainContato mainContatos = new MainContato();
            mainContatos.Dock = DockStyle.Fill;
            mainContatos.TopLevel = false;
            TelaPrincipal.mainPanel.Controls.Clear();
            TelaPrincipal.mainPanel.Controls.Add(mainContatos);
            mainContatos.Show();
        }

        private void btCalendario_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            if (telaAtual is MainCalendario)
            {
                return;
            }
            MainCalendario mainCalendario = new MainCalendario();
            mainCalendario.Dock = DockStyle.Fill;
            mainCalendario.TopLevel = false;
            TelaPrincipal.mainPanel.Controls.Clear();
            TelaPrincipal.mainPanel.Controls.Add(mainCalendario);
            mainCalendario.Show();
        }

        private void btSenhas_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            if (telaAtual is MainSenhas)
            {
                return;
            }
            MainSenhas mainSenhas = new MainSenhas();
            mainSenhas.Dock = DockStyle.Fill;
            mainSenhas.TopLevel = false;
            TelaPrincipal.mainPanel.Controls.Clear();
            TelaPrincipal.mainPanel.Controls.Add(mainSenhas);
            mainSenhas.Show();
        } 
        }
    }