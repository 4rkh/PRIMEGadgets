using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
