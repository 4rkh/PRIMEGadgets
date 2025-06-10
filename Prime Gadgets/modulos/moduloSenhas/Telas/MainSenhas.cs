using Prime_Gadgets.modulos.moduloContatos;
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
        private List<Senhas> _senhas = new();
        private int _paginaAtual = 1;
        private int _totalPaginas = 1;
        private const int _tamanhoPagina = 30;
        public string caminhoRelativo = "modulos\\moduloSenhas\\Repositorios\\Senhas.prime";
        public string caminho;
        Criptografia criptografia = new Criptografia();
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
            _senhas = senhaAccess.OrdenarSenhasPorId(senhaAccess.LerSenhas());

            // Calcula o total de páginas
            _totalPaginas = (_senhas.Count + _tamanhoPagina - 1) / _tamanhoPagina;
            if (_totalPaginas == 0) _totalPaginas = 1;
            if (_paginaAtual > _totalPaginas) _paginaAtual = _totalPaginas;
            if (_paginaAtual < 1) _paginaAtual = 1;

            // Seleciona as senhas da página atual
            int inicio = (_paginaAtual - 1) * _tamanhoPagina;
            var senhasPagina = _senhas.Skip(inicio).Take(_tamanhoPagina);

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nome de Usuário");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Senha");
            dataTable.Columns.Add("Origem");

            foreach (var senha in senhasPagina)
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

            // Atualiza as labels de página
            lbMainSenhasPgAtual.Text = _paginaAtual.ToString();
            lbMainSenhasPgFinal.Text = _totalPaginas.ToString();
            AtualizarEstadoBotoesNavegacao();
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
            UpdateSenhas updateSenhas = new UpdateSenhas(senha);
            updateSenhas.ShowDialog();
            LerTabela();
        }

        private void btMainSenhasHome_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void AtualizarEstadoBotoesNavegacao()
        {
            // Primeira página: desabilita 'first' e 'back'
            if (_paginaAtual == 1)
            {
                btMainSenhasFirst.Enabled = false;
                btMainSenhasBack.Enabled = false;
                btMainSenhasFirst.BackColor = Color.FromArgb(52, 60, 76);
                btMainSenhasBack.BackColor = Color.FromArgb(52, 60, 76);
            }
            else
            {
                btMainSenhasFirst.Enabled = true;
                btMainSenhasBack.Enabled = true;
                btMainSenhasFirst.BackColor = Color.FromArgb(230, 34, 34);
                btMainSenhasBack.BackColor = Color.FromArgb(230, 34, 34);
            }

            // Última página: desabilita 'end' e 'next'
            if (_paginaAtual == _totalPaginas)
            {
                btMainSenhasLast.Enabled = false;
                btMainSenhasNext.Enabled = false;
                btMainSenhasLast.BackColor = Color.FromArgb(52, 60, 76);
                btMainSenhasNext.BackColor = Color.FromArgb(52, 60, 76);
            }
            else
            {
                btMainSenhasLast.Enabled = true;
                btMainSenhasNext.Enabled = true;
                btMainSenhasLast.BackColor = Color.FromArgb(230, 34, 34);
                btMainSenhasNext.BackColor = Color.FromArgb(230, 34, 34);
            }
        }

        private void btMainSenhasLast_Click(object sender, EventArgs e)
        {
            if (_paginaAtual != _totalPaginas)
            {
                _paginaAtual = _totalPaginas;
                LerTabela();
            }
        }

        private void btMainSenhasNext_Click(object sender, EventArgs e)
        {
            if (_paginaAtual < _totalPaginas)
            {
                _paginaAtual++;
                LerTabela();
            }
        }

        private void btMainSenhasBack_Click(object sender, EventArgs e)
        {
            if (_paginaAtual > 1)
            {
                _paginaAtual--;
                LerTabela();
            }
        }

        private void btMainSenhasFirst_Click(object sender, EventArgs e)
        {
            if (_paginaAtual != 1)
            {
                _paginaAtual = 1;
                LerTabela();
            }
        }
        private void MainSenhas_VisibleChanged(object sender, EventArgs e)
        {
            string diretorioProjeto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            caminho = Path.Combine(diretorioProjeto, caminhoRelativo);

            
            if (!this.Visible)
            {
                criptografia.EncryptFile(caminho, caminho + ".enc");
            } else
            {
                if (File.Exists(caminho + ".enc"))
                {
                    criptografia.DecryptFile(caminho + ".enc", caminho);
                    LerTabela();
                }
            }

        }
    }
}


