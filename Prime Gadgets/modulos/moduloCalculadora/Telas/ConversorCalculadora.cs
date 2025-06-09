using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloCalculadora
{
    public partial class ConversorCalculadora : Form
    {
        public ConversorCalculadora()
        {
            InitializeComponent();
            cbConversorCalculadoraTipo.DataSource = Conversor.TiposConversao;
            cbConversorCalculadoraTipo.DisplayMember = "Texto";
            cbConversorCalculadoraTipo.ValueMember = "Valor";
        }


        private void btConversorCalculadoraCancelar_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            telaAtual.Close();
        }

        private void btConversorCalculadoraConverter_Click(object sender, EventArgs e)
        {
            // Validação de entrada
            if (string.IsNullOrWhiteSpace(campConversorCalculadoraNumero1.Text))
            {
                MessageBox.Show("Digite um valor para converter.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double valorEntrada;
            if (!double.TryParse(campConversorCalculadoraNumero1.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out valorEntrada))
            {
                MessageBox.Show("Valor inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tipoConversao = cbConversorCalculadoraTipo.SelectedItem as Conversor;
            if (tipoConversao == null) return;

            double resultado = 0;
            string resultadoTexto = "";

            // Temperatura
            if (tipoConversao.Valor == 1)
            {
                var unidadeOrigem = cbConversorCalculadoraUnidade1.SelectedItem as Conversor;
                var unidadeDestino = cbConversorCalculadoraUnidade2.SelectedItem as Conversor;
                if (unidadeOrigem == null || unidadeDestino == null || unidadeOrigem.Valor == 0 || unidadeDestino.Valor == 0)
                {
                    MessageBox.Show("Selecione as unidades de temperatura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Celsius
                if (unidadeOrigem.Valor == 1)
                {
                    if (unidadeDestino.Valor == 1) resultado = valorEntrada;
                    else if (unidadeDestino.Valor == 2) resultado = valorEntrada * 9 / 5 + 32; // Celsius -> Fahrenheit
                    else if (unidadeDestino.Valor == 3) resultado = valorEntrada + 273.15; // Celsius -> Kelvin
                }
                // Fahrenheit
                else if (unidadeOrigem.Valor == 2)
                {
                    if (unidadeDestino.Valor == 1) resultado = (valorEntrada - 32) * 5 / 9; // Fahrenheit -> Celsius
                    else if (unidadeDestino.Valor == 2) resultado = valorEntrada;
                    else if (unidadeDestino.Valor == 3) resultado = (valorEntrada - 32) * 5 / 9 + 273.15; // Fahrenheit -> Kelvin
                }
                // Kelvin
                else if (unidadeOrigem.Valor == 3)
                {
                    if (unidadeDestino.Valor == 1) resultado = valorEntrada - 273.15; // Kelvin -> Celsius
                    else if (unidadeDestino.Valor == 2) resultado = (valorEntrada - 273.15) * 9 / 5 + 32; // Kelvin -> Fahrenheit
                    else if (unidadeDestino.Valor == 3) resultado = valorEntrada;
                }

                resultadoTexto = resultado.ToString("N2");
            }
            // Distância
            else if (tipoConversao.Valor == 2)
            {
                var tipoOrigem = cbConversorCalculadoraTipoUnidade1.SelectedItem as Conversor;
                var tipoDestino = cbConversorCalculadoraTipoUnidade2.SelectedItem as Conversor;
                var unidadeOrigem = cbConversorCalculadoraUnidade1.SelectedItem as Conversor;
                var unidadeDestino = cbConversorCalculadoraUnidade2.SelectedItem as Conversor;

                if (tipoOrigem == null || tipoDestino == null || unidadeOrigem == null || unidadeDestino == null ||
                    tipoOrigem.Valor == 0 || tipoDestino.Valor == 0 || unidadeOrigem.Valor == 0 || unidadeDestino.Valor == 0)
                {
                    MessageBox.Show("Selecione os tipos e unidades de distância.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Converte tudo para metros como base
                double valorEmMetros = 0;

                // Métrico
                if (tipoOrigem.Valor == 1)
                {
                    switch (unidadeOrigem.Valor)
                    {
                        case 1: valorEmMetros = valorEntrada / 1000; break; // Milímetro -> Metro
                        case 2: valorEmMetros = valorEntrada / 100; break;  // Centímetro -> Metro
                        case 3: valorEmMetros = valorEntrada; break;        // Metro
                        case 4: valorEmMetros = valorEntrada * 1000; break; // Quilômetro -> Metro
                    }
                }
                // Imperial
                else if (tipoOrigem.Valor == 2)
                {
                    switch (unidadeOrigem.Valor)
                    {
                        case 1: valorEmMetros = valorEntrada * 0.0254; break;   // Polegada
                        case 2: valorEmMetros = valorEntrada * 0.3048; break;   // Pé
                        case 3: valorEmMetros = valorEntrada * 0.9144; break;   // Jarda
                        case 4: valorEmMetros = valorEntrada * 1609.344; break; // Milha
                    }
                }

                // Agora converte de metros para unidade de destino
                double valorConvertido = 0;
                if (tipoDestino.Valor == 1)
                {
                    switch (unidadeDestino.Valor)
                    {
                        case 1: valorConvertido = valorEmMetros * 1000; break; // Metro -> Milímetro
                        case 2: valorConvertido = valorEmMetros * 100; break;  // Metro -> Centímetro
                        case 3: valorConvertido = valorEmMetros; break;        // Metro
                        case 4: valorConvertido = valorEmMetros / 1000; break; // Metro -> Quilômetro
                    }
                }
                else if (tipoDestino.Valor == 2)
                {
                    switch (unidadeDestino.Valor)
                    {
                        case 1: valorConvertido = valorEmMetros / 0.0254; break;   // Metro -> Polegada
                        case 2: valorConvertido = valorEmMetros / 0.3048; break;   // Metro -> Pé
                        case 3: valorConvertido = valorEmMetros / 0.9144; break;   // Metro -> Jarda
                        case 4: valorConvertido = valorEmMetros / 1609.344; break; // Metro -> Milha
                    }
                }

                resultadoTexto = valorConvertido.ToString("N4");
            }
            // Numérico (Binário/Decimal)
            else if (tipoConversao.Valor == 3)
            {
                var unidadeOrigem = cbConversorCalculadoraUnidade1.SelectedItem as Conversor;
                var unidadeDestino = cbConversorCalculadoraUnidade2.SelectedItem as Conversor;
                if (unidadeOrigem == null || unidadeDestino == null || unidadeOrigem.Valor == 0 || unidadeDestino.Valor == 0)
                {
                    MessageBox.Show("Selecione as bases numéricas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    if (unidadeOrigem.Valor == 1 && unidadeDestino.Valor == 2)
                    {
                        // Binário para Decimal
                        int dec = Convert.ToInt32(campConversorCalculadoraNumero1.Text, 2);
                        resultadoTexto = dec.ToString();
                    }
                    else if (unidadeOrigem.Valor == 2 && unidadeDestino.Valor == 1)
                    {
                        // Decimal para Binário
                        int dec = int.Parse(campConversorCalculadoraNumero1.Text);
                        resultadoTexto = Convert.ToString(dec, 2);
                    }
                    else
                    {
                        resultadoTexto = campConversorCalculadoraNumero1.Text;
                    }
                }
                catch
                {
                    MessageBox.Show("Valor inválido para conversão numérica.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione um tipo de conversão válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            campConversorCalculadoraNumero2.Text = resultadoTexto;
        }

        private void cbConversorCalculadoraTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbConversorCalculadoraTipoUnidade1.Visible = false;
            cbConversorCalculadoraTipoUnidade2.Visible = false;
            var conversor = cbConversorCalculadoraTipo.SelectedItem as Conversor;
            if (conversor.Valor == 0)
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.ConversaoBloqueada;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.ConversaoBloqueada;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = false;
                cbConversorCalculadoraUnidade2.Enabled = false;
            }
            else if (conversor.Valor == 1)
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipoT1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoT2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
                cbConversorCalculadoraUnidade2.Enabled = true;
            }
            else if (conversor.Valor == 2)
            {
                cbConversorCalculadoraTipoUnidade1.SelectedValue = 0;
                cbConversorCalculadoraTipoUnidade2.SelectedValue = 0;
                cbConversorCalculadoraTipoUnidade1.DataSource = Conversor.TipoCD1Conversao;
                cbConversorCalculadoraTipoUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraTipoUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraTipoUnidade2.DataSource = Conversor.TipoCD2Conversao;
                cbConversorCalculadoraTipoUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraTipoUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraTipoUnidade1.Visible = true;
                cbConversorCalculadoraTipoUnidade2.Visible = true;
            }
            else if (conversor.Valor == 3)
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipoC1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoC2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
                cbConversorCalculadoraUnidade2.Enabled = true;
            }

        }

        private void btConversorCalculadoraInverter_Click(object sender, EventArgs e)
        {
            int tipoSelecionado = cbConversorCalculadoraTipo.SelectedIndex;

            if (tipoSelecionado == 1 || tipoSelecionado == 3)
            {
                // Inversão simples para os modos 1 e 3
                int idx1 = cbConversorCalculadoraUnidade1.SelectedIndex;
                int idx2 = cbConversorCalculadoraUnidade2.SelectedIndex;

                cbConversorCalculadoraUnidade1.SelectedIndex = idx2;
                cbConversorCalculadoraUnidade2.SelectedIndex = idx1;
            }
            else if (tipoSelecionado == 2)
            {
                // Salva os índices atuais de unidade
                int idxUn1 = cbConversorCalculadoraUnidade1.SelectedIndex;
                int idxUn2 = cbConversorCalculadoraUnidade2.SelectedIndex;

                // Inverte os tipos (Métrico/Imperial)
                int idxTipo1 = cbConversorCalculadoraTipoUnidade1.SelectedIndex;
                int idxTipo2 = cbConversorCalculadoraTipoUnidade2.SelectedIndex;

                cbConversorCalculadoraTipoUnidade1.SelectedIndex = idxTipo2;
                cbConversorCalculadoraTipoUnidade2.SelectedIndex = idxTipo1;

                // Força a atualização das listas de unidades
                cbConversorCalculadoraTipoUnidade1_SelectedIndexChanged(null, null);
                cbConversorCalculadoraTipoUnidade2_SelectedIndexChanged(null, null);

                // Agora, inverte as unidades (se forem válidas após a atualização)
                int maxUn1 = cbConversorCalculadoraUnidade1.Items.Count;
                int maxUn2 = cbConversorCalculadoraUnidade2.Items.Count;

                if (idxUn2 < maxUn1) cbConversorCalculadoraUnidade1.SelectedIndex = idxUn2;
                if (idxUn1 < maxUn2) cbConversorCalculadoraUnidade2.SelectedIndex = idxUn1;
            }
        }
        private void cbConversorCalculadoraTipoUnidade1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var conversor = cbConversorCalculadoraTipoUnidade1.SelectedItem as Conversor;
            if (conversor.Valor == 0)
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.ConversaoBloqueada;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = false;
            }
            else if (conversor.Valor == 1)
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipoCM1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
            }
            else if (conversor.Valor == 2)
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipCI1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
            }
        }

        private void cbConversorCalculadoraTipoUnidade2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var conversor = cbConversorCalculadoraTipoUnidade2.SelectedItem as Conversor;
            if (conversor.Valor == 0)
            {
                cbConversorCalculadoraUnidade2.DataSource = Conversor.ConversaoBloqueada;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.Enabled = false;
            }
            else if (conversor.Valor == 1)
            {
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoCM2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.Enabled = true;
            } else if(conversor.Valor == 2)
            {
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoCI2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.Enabled = true;
            }
        }
    }
}
