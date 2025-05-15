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
            try
            {
                string diretorio = "modulos\\moduloSenhas\\Repositorios";
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }

                string caminhoArquivo = Path.Combine(diretorio, "Senhas.prime");
                if (!File.Exists(caminhoArquivo))
                {
                    using (File.Create(caminhoArquivo)) { }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("SenhasMain error. Problema ao tentar ler o arquivo Senhas.prime " + e.Message);
            }

            InitializeComponent();
            LerTabela();
        }

        public void LerTabela()
        {
            var senhaAccess = new SenhaAccess();
            List<Senhas> senhas = senhaAccess.LerSenhas();
            senhas = senhaAccess.OrdenarSenhasPorId(senhas);

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nome de Usuário");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Senha");
            dataTable.Columns.Add("Origem");

            foreach (var senha in senhas)
            {
                var row = dataTable.NewRow();
                row["ID"] = senha.Id;
                row["Nome de Usuário"] = senha.NomeDeUsuario;
                row["Email"] = senha.Email;
                row["Senha"] = new string('*', senha.Senha.Length);
                row["Origem"] = senha.Origem;
                dataTable.Rows.Add(row);
            }

            this.tbMainSenhasDados.DataSource = dataTable;
        }


        public Senhas SenhaSelect()
        {
            if (tbMainSenhasDados.SelectedRows.Count > 0)
            {
                var selectedRow = tbMainSenhasDados.SelectedRows[0];
                return new Senhas
                {
                    Id = Convert.ToInt32(selectedRow.Cells["ID"].Value),
                    NomeDeUsuario = selectedRow.Cells["Nome de Usuário"].Value.ToString(),
                    Email = selectedRow.Cells["Email"].Value.ToString(),
                    Senha = selectedRow.Cells["Senha"].Value.ToString(),
                    Origem = selectedRow.Cells["Origem"].Value.ToString()
                };
            }
            return null;
        }

        private void btMainSenhasCreate_Click(object sender, EventArgs e)
        {
            CreateSenhas createSenhas = new CreateSenhas();
            createSenhas.ShowDialog();
            LerTabela();
        }

        private void btMainSenhasDelete_Click(object sender, EventArgs e)
        {
            var senha = SenhaSelect();
            if (senha != null)
            {
                var result = MessageBox.Show($"Você deseja deletar a senha para o usuário '{senha.NomeDeUsuario}'?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SenhaAccess senhaAccess = new SenhaAccess();
                    senhaAccess.DeleteSenha(senha.Id);
                    LerTabela();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma senha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btMainSenhasUpdate_Click(object sender, EventArgs e)
        {
            var senha = SenhaSelect();
            UpdateSenhas updateSenhas = new UpdateSenhas(/*senha*/);
            updateSenhas.ShowDialog();
            LerTabela();
        }
    }
}


