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
        private List<Contatos> _contatos = new();
        private int _paginaAtual = 1;
        private int _totalPaginas = 1;
        private const int _tamanhoPagina = 30;

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
                MessageBox.Show("MainContato error. Problema ao tentar ler o arquivo Contatos.prime " + e.Message);

            }

            InitializeComponent();
            LerTabela();
        }

        public void LerTabela()
        {
            var contatoAccess = new ContatoAccess();
            _contatos = contatoAccess.OrdenarContatosPorId(contatoAccess.LerContatos());

            // Calcula o total de páginas
            _totalPaginas = (_contatos.Count + _tamanhoPagina - 1) / _tamanhoPagina;
            if (_totalPaginas == 0) _totalPaginas = 1;
            if (_paginaAtual > _totalPaginas) _paginaAtual = _totalPaginas;
            if (_paginaAtual < 1) _paginaAtual = 1;

            // Seleciona os contatos da página atual
            int inicio = (_paginaAtual - 1) * _tamanhoPagina;
            var contatosPagina = _contatos.Skip(inicio).Take(_tamanhoPagina);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Sobrenome");
            dataTable.Columns.Add("Telefone");
            dataTable.Columns.Add("Email");

            foreach (var contato in contatosPagina)
            {
                var row = dataTable.NewRow();
                row["ID"] = contato.Id;
                row["Nome"] = contato.Nome;
                row["Sobrenome"] = contato.Sobrenome;
                row["Telefone"] = contato.Telefone;
                row["Email"] = contato.Email;
                dataTable.Rows.Add(row);
            }

            this.dtMainContatosLista.DataSource = dataTable;

            // Atualiza as labels de página
            lbMainContatosPgAtual.Text = _paginaAtual.ToString();
            lbMainContatosPgFinal.Text = _totalPaginas.ToString();
            AtualizarEstadoBotoesNavegacao();
        }

        public Contatos ContatoSelect()
        {
            if (dtMainContatosLista.SelectedRows.Count > 0)
            {
                var selectedRow = dtMainContatosLista.SelectedRows[0];
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
        private void btMainContatosDelete_Click(object sender, EventArgs e)
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
        //inicializar uma list<contatos>
        //update contato exibe a tela e os campo que sao capturados anteriormente na linha selecionada
        //substituir os valore na list<contatos>
        //fazer o sort na lista
        //salvar a lista no arquivo

        private void btMainContatosUpdate_Click(object sender, EventArgs e)
        {
            var contato = ContatoSelect();
            UpdateContato updateContato = new UpdateContato(contato);
            updateContato.ShowDialog();
            LerTabela();
        }

        private void btMainContatosFirst_Click(object sender, EventArgs e)
        {
            if (_paginaAtual != 1)
            {
                _paginaAtual = 1;
                LerTabela();
            }
        }

        // Botão VOLTAR página
        private void btMainContatosBack_Click(object sender, EventArgs e)
        {
            if (_paginaAtual > 1)
            {
                _paginaAtual--;
                LerTabela();
            }
        }

        // Botão AVANÇAR página
        private void btMainContatosNext_Click(object sender, EventArgs e)
        {
            if (_paginaAtual < _totalPaginas)
            {
                _paginaAtual++;
                LerTabela();
            }
        }

        // Botão ÚLTIMA página
        private void btMainContatosLast_Click(object sender, EventArgs e)
        {
            if (_paginaAtual != _totalPaginas)
            {
                _paginaAtual = _totalPaginas;
                LerTabela();
            }
        }
        private void AtualizarEstadoBotoesNavegacao()
        {
            // Primeira página: desabilita 'first' e 'back'
            if (_paginaAtual == 1)
            {
                btMainContatosFirst.Enabled = false;
                btMainContatosBack.Enabled = false;
                btMainContatosFirst.BackColor = Color.LightGray;
                btMainContatosBack.BackColor = Color.LightGray;
            }
            else
            {
                btMainContatosFirst.Enabled = true;
                btMainContatosBack.Enabled = true;
                btMainContatosFirst.BackColor = SystemColors.Control;
                btMainContatosBack.BackColor = SystemColors.Control;
            }

            // Última página: desabilita 'end' e 'next'
            if (_paginaAtual == _totalPaginas)
            {
                btMainContatosLast.Enabled = false;
                btMainContatosNext.Enabled = false;
                btMainContatosLast.BackColor = Color.LightGray;
                btMainContatosNext.BackColor = Color.LightGray;
            }
            else
            {
                btMainContatosLast.Enabled = true;
                btMainContatosNext.Enabled = true;
                btMainContatosLast.BackColor = SystemColors.Control;
                btMainContatosNext.BackColor = SystemColors.Control;
            }
        }
    }
}