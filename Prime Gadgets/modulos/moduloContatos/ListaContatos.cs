#pragma warning disable
#pragma warning disable CS0162
using Prime_Gadgets.modulos.moduloContatos.Repositorios;
using System.Data;

namespace Prime_Gadgets
{
    public partial class ListaContatos : Form
    {
        public ListaContatos()
        {
            try
            {
                if (!File.Exists("modulos\\moduloContatos\\Repositorios\\Contatos.prime")) { 
                    File.Create("modulos\\moduloContatos\\Repositorios\\Contatos.prime").Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Problema ao tentar ler o arquivo Contatos.prime"  +e.Message);

            }

            InitializeComponent();
            LerTabela();
        }

        private void LerTabela()
        {
            var contatoAccess = new ContatoAccess();
            var contatos = contatoAccess.exibirContatos();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
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

    }
}

#pragma warning restore
#pragma warning restore CS0162