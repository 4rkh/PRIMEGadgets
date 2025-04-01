using Prime_Gadgets.Models;
using Prime_Gadgets.modulos.moduloContatos.Modelos;
using Prime_Gadgets.modulos.moduloContatos.Repositorios;
using System.Data;

namespace Prime_Gadgets
{
    public partial class PrincipalContato : Form
    {
        public PrincipalContato()
        {
            try
            {
                string diretorio = "modulos\\moduloContatos\\Repositorios";
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }

                string caminhoArquivo = Path.Combine(diretorio, "Contatos.prime");
                if (!File.Exists(caminhoArquivo))
                {
                    using (File.Create(caminhoArquivo)) { }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("PrincipalContato error. Problema ao tentar ler o arquivo Contatos.prime " + e.Message);

            }

            InitializeComponent();
            LerTabela();
        }

        public void LerTabela()
        {
            var contatoAccess = new ContatoAccess();
            var contatos = contatoAccess.exibirContatos();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Sobrenome");
            dataTable.Columns.Add("Telefone");
            dataTable.Columns.Add("Email");

            foreach (var contato in contatos)
            {
                var row = dataTable.NewRow();
                row["ID"] = contato.Id;
                row["Nome"] = contato.Nome;
                row["Sobrenome"] = contato.Sobrenome;
                row["Telefone"] = contato.Telefone;
                row["Email"] = contato.Email;
                dataTable.Rows.Add(row);
            }

            this.contatosTable.DataSource = dataTable;
        }
        public Contatos ContatoSelectId()
        {
            if (contatosTable.SelectedRows.Count > 0)
            {
                var selectedRow = contatosTable.SelectedRows[0];
                return new Contatos
                {
                    Id = Convert.ToInt32(selectedRow.Cells["ID"].Value),
                    Nome = selectedRow.Cells["Nome"].Value.ToString(),
                    Sobrenome = selectedRow.Cells["Sobrenome"].Value.ToString(),
                    Telefone = selectedRow.Cells["Telefone"].Value.ToString(),
                    Email = selectedRow.Cells["Email"].Value.ToString()
                };
            }
            return null;
        }
        private void Create_Click(object sender, EventArgs e)
        {
            CreateContato createContato = new CreateContato();
            createContato.ShowDialog();
            LerTabela();
        }

        private void contatosTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btPrincipalContatosDelete_Click(object sender, EventArgs e)
        {
            var contato = ContatoSelectId();
            if (contato != null)
            {
                var result = MessageBox.Show($"Você deseja deletar o contato \"{contato.Nome}\"?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ContatoAccess contatoAccess = new ContatoAccess();
                    contatoAccess.DeleteContato(contato.Id);
                    LerTabela();
                }
            }
            else
            {
                MessageBox.Show("Nenhum contato selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

