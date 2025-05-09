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
using Prime_Gadgets.modulos.moduloCalendario.Telas;

namespace Prime_Gadgets
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btMenuPrincipalContatos_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalContato principalContato = new PrincipalContato();
            {
                principalContato.ShowDialog();
            }
            this.Show();
        }

        private void btMenuPrincipalCalendario_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalCalendario principalCalendario = new PrincipalCalendario();
            {
                principalCalendario.ShowDialog();
            }
            this.Show();
        }
    }
}
