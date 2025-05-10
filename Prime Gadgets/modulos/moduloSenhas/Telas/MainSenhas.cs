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
    public partial class MainSenhas : Form
    {
        public MainSenhas()
        {
            InitializeComponent();
        }

        private void btMainSenhasCreate_Click(object sender, EventArgs e)
        {
            CreateSenhas createSenhas = new CreateSenhas();
            createSenhas.ShowDialog();
        }

        private void btMainSenhasUpdate_Click(object sender, EventArgs e)
        {
            UpdateSenhas updateSenhas = new UpdateSenhas();
            updateSenhas.ShowDialog();
        }

        private void btMainSenhasDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
