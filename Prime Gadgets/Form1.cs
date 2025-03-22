using Prime_Gadgets.Repository;
using System.Data;

namespace Prime_Gadgets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LerTabela();
        }

        private void LerTabela()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Sobrenome");
            dataTable.Columns.Add("Telefone");
            dataTable.Columns.Add("Email");

            var repo = new ContatosRepository();
            var contatos = repo.GetAllContatos();

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

    }
}
