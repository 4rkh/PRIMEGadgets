using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloContatos
{

    public partial class MainContato : Form
    {
        public MainContato()
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
            List<Contatos> contatos = contatoAccess.LerContatos();
            contatos = contatoAccess.OrdenarContatosPorId(contatos);

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

            this.ContatosTable.DataSource = dataTable;
        }
        public Contatos ContatoSelect()
        {
            if (ContatosTable.SelectedRows.Count > 0)
            {
                var selectedRow = ContatosTable.SelectedRows[0];
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
        private void btPrincipalContatosDelete_Click(object sender, EventArgs e)
        {
            var contato = ContatoSelect();
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
        

        //clicar botao chama UpdateContato()
        //inicializar uam list<contatos>
        //update contato exibe a tela e os campo que sao capturados anteriormente na linha selecionada
        //substituir os valore na list<contatos>
        //fazer o sort na lista
        //salvar a lista no arquivo

        private void btPrincipalContatosUpdate_Click(object sender, EventArgs e)
        {
            var contato = ContatoSelect();
            UpdateContato updateContato = new UpdateContato(contato);
            updateContato.ShowDialog();
            LerTabela();
        }
    }
}

