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
    public partial class TelaPrincipal : Form
    {
        public static Panel mainPanel;
        public TelaPrincipal()
        {
            InitializeComponent();
            mainPanel = panelPrime;
        }

        private void panelHome_Enter(object sender, EventArgs e)
        {
            MainHome homeTela = new MainHome();
            homeTela.Dock = DockStyle.Fill;
            homeTela.TopLevel = false;
            panelPrime.Controls.Clear();
            panelPrime.Controls.Add(homeTela);
            homeTela.Show();
        }
    }
}