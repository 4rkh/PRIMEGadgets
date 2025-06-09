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
            // Numérico (Binário/Decimal/Hexadecimal)
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
                    int dec = 0;
                    // Converter para decimal primeiro
                    if (unidadeOrigem.Valor == 1) // Binário
                        dec = Convert.ToInt32(campConversorCalculadoraNumero1.Text, 2);
                    else if (unidadeOrigem.Valor == 2) // Decimal
                        dec = int.Parse(campConversorCalculadoraNumero1.Text);
                    else if (unidadeOrigem.Valor == 3) // Hexadecimal
                        dec = Convert.ToInt32(campConversorCalculadoraNumero1.Text, 16);

                    // Converter do decimal para destino
                    if (unidadeDestino.Valor == 1) // Binário
                        resultadoTexto = Convert.ToString(dec, 2);
                    else if (unidadeDestino.Valor == 2) // Decimal
                        resultadoTexto = dec.ToString();
                    else if (unidadeDestino.Valor == 3) // Hexadecimal
                        resultadoTexto = dec.ToString("X");
                }
                catch
                {
                    MessageBox.Show("Valor inválido para conversão numérica.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Massa
            else if (tipoConversao.Valor == 4)
            {
                var unidadeOrigem = cbConversorCalculadoraUnidade1.SelectedItem as Conversor;
                var unidadeDestino = cbConversorCalculadoraUnidade2.SelectedItem as Conversor;
                if (unidadeOrigem == null || unidadeDestino == null || unidadeOrigem.Valor == 0 || unidadeDestino.Valor == 0)
                {
                    MessageBox.Show("Selecione as unidades de massa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Converte tudo para quilograma
                double valorEmKg = valorEntrada;
                switch (unidadeOrigem.Valor)
                {
                    case 1: valorEmKg = valorEntrada; break; // Quilograma
                    case 2: valorEmKg = valorEntrada / 1000; break; // Grama
                    case 3: valorEmKg = valorEntrada * 1000; break; // Tonelada
                    case 4: valorEmKg = valorEntrada * 0.45359237; break; // Libra
                    case 5: valorEmKg = valorEntrada * 0.0283495231; break; // Onça
                }
                // Converte de kg para destino
                switch (unidadeDestino.Valor)
                {
                    case 1: resultado = valorEmKg; break; // Quilograma
                    case 2: resultado = valorEmKg * 1000; break; // Grama
                    case 3: resultado = valorEmKg / 1000; break; // Tonelada
                    case 4: resultado = valorEmKg / 0.45359237; break; // Libra
                    case 5: resultado = valorEmKg / 0.0283495231; break; // Onça
                }
                resultadoTexto = resultado.ToString("N4");
            }
            // Tempo
            else if (tipoConversao.Valor == 5)
            {
                var unidadeOrigem = cbConversorCalculadoraUnidade1.SelectedItem as Conversor;
                var unidadeDestino = cbConversorCalculadoraUnidade2.SelectedItem as Conversor;
                if (unidadeOrigem == null || unidadeDestino == null || unidadeOrigem.Valor == 0 || unidadeDestino.Valor == 0)
                {
                    MessageBox.Show("Selecione as unidades de tempo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Converte tudo para segundos
                double valorEmSegundos = valorEntrada;
                switch (unidadeOrigem.Valor)
                {
                    case 1: valorEmSegundos = valorEntrada; break; // Segundo
                    case 2: valorEmSegundos = valorEntrada * 60; break; // Minuto
                    case 3: valorEmSegundos = valorEntrada * 3600; break; // Hora
                    case 4: valorEmSegundos = valorEntrada * 86400; break; // Dia
                }
                // Converte de segundos para destino
                switch (unidadeDestino.Valor)
                {
                    case 1: resultado = valorEmSegundos; break; // Segundo
                    case 2: resultado = valorEmSegundos / 60; break; // Minuto
                    case 3: resultado = valorEmSegundos / 3600; break; // Hora
                    case 4: resultado = valorEmSegundos / 86400; break; // Dia
                }
                resultadoTexto = resultado.ToString("N4");
            }
            // Área
            else if (tipoConversao.Valor == 6)
            {
                var unidadeOrigem = cbConversorCalculadoraUnidade1.SelectedItem as Conversor;
                var unidadeDestino = cbConversorCalculadoraUnidade2.SelectedItem as Conversor;
                if (unidadeOrigem == null || unidadeDestino == null || unidadeOrigem.Valor == 0 || unidadeDestino.Valor == 0)
                {
                    MessageBox.Show("Selecione as unidades de área.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Converte tudo para metro quadrado
                double valorEmM2 = valorEntrada;
                switch (unidadeOrigem.Valor)
                {
                    case 1: valorEmM2 = valorEntrada; break; // Metro quadrado
                    case 2: valorEmM2 = valorEntrada * 1_000_000; break; // Km²
                    case 3: valorEmM2 = valorEntrada * 10_000; break; // Hectare
                    case 4: valorEmM2 = valorEntrada * 4046.85642; break; // Acre
                }
                // Converte de m² para destino
                switch (unidadeDestino.Valor)
                {
                    case 1: resultado = valorEmM2; break; // Metro quadrado
                    case 2: resultado = valorEmM2 / 1_000_000; break; // Km²
                    case 3: resultado = valorEmM2 / 10_000; break; // Hectare
                    case 4: resultado = valorEmM2 / 4046.85642; break; // Acre
                }
                resultadoTexto = resultado.ToString("N4");
            }
            // Volume
            else if (tipoConversao.Valor == 7)
            {
                var unidadeOrigem = cbConversorCalculadoraUnidade1.SelectedItem as Conversor;
                var unidadeDestino = cbConversorCalculadoraUnidade2.SelectedItem as Conversor;
                if (unidadeOrigem == null || unidadeDestino == null || unidadeOrigem.Valor == 0 || unidadeDestino.Valor == 0)
                {
                    MessageBox.Show("Selecione as unidades de volume.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Converte tudo para litros
                double valorEmLitros = valorEntrada;
                switch (unidadeOrigem.Valor)
                {
                    case 1: valorEmLitros = valorEntrada; break; // Litro
                    case 2: valorEmLitros = valorEntrada / 1000; break; // Mililitro
                    case 3: valorEmLitros = valorEntrada * 1000; break; // Metro cúbico
                    case 4: valorEmLitros = valorEntrada * 3.78541; break; // Galão (EUA)
                }
                // Converte de litros para destino
                switch (unidadeDestino.Valor)
                {
                    case 1: resultado = valorEmLitros; break; // Litro
                    case 2: resultado = valorEmLitros * 1000; break; // Mililitro
                    case 3: resultado = valorEmLitros / 1000; break; // Metro cúbico
                    case 4: resultado = valorEmLitros / 3.78541; break; // Galão (EUA)
                }
                resultadoTexto = resultado.ToString("N4");
            }
            // Velocidade
            else if (tipoConversao.Valor == 8)
            {
                var unidadeOrigem = cbConversorCalculadoraUnidade1.SelectedItem as Conversor;
                var unidadeDestino = cbConversorCalculadoraUnidade2.SelectedItem as Conversor;
                if (unidadeOrigem == null || unidadeDestino == null || unidadeOrigem.Valor == 0 || unidadeDestino.Valor == 0)
                {
                    MessageBox.Show("Selecione as unidades de velocidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Converte tudo para m/s
                double valorEmMS = valorEntrada;
                switch (unidadeOrigem.Valor)
                {
                    case 1: valorEmMS = valorEntrada; break; // m/s
                    case 2: valorEmMS = valorEntrada / 3.6; break; // km/h
                    case 3: valorEmMS = valorEntrada * 0.44704; break; // mph
                    case 4: valorEmMS = valorEntrada * 0.514444; break; // nó
                }
                // Converte de m/s para destino
                switch (unidadeDestino.Valor)
                {
                    case 1: resultado = valorEmMS; break; // m/s
                    case 2: resultado = valorEmMS * 3.6; break; // km/h
                    case 3: resultado = valorEmMS / 0.44704; break; // mph
                    case 4: resultado = valorEmMS / 0.514444; break; // nó
                }
                resultadoTexto = resultado.ToString("N4");
            }
            // Pressão
            else if (tipoConversao.Valor == 9)
            {
                var unidadeOrigem = cbConversorCalculadoraUnidade1.SelectedItem as Conversor;
                var unidadeDestino = cbConversorCalculadoraUnidade2.SelectedItem as Conversor;
                if (unidadeOrigem == null || unidadeDestino == null || unidadeOrigem.Valor == 0 || unidadeDestino.Valor == 0)
                {
                    MessageBox.Show("Selecione as unidades de pressão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Converte tudo para Pascal
                double valorEmPascal = valorEntrada;
                switch (unidadeOrigem.Valor)
                {
                    case 1: valorEmPascal = valorEntrada; break; // Pascal
                    case 2: valorEmPascal = valorEntrada * 100000; break; // Bar
                    case 3: valorEmPascal = valorEntrada * 101325; break; // Atmosfera
                    case 4: valorEmPascal = valorEntrada * 133.322; break; // mmHg
                }
                // Converte de Pascal para destino
                switch (unidadeDestino.Valor)
                {
                    case 1: resultado = valorEmPascal; break; // Pascal
                    case 2: resultado = valorEmPascal / 100000; break; // Bar
                    case 3: resultado = valorEmPascal / 101325; break; // Atmosfera
                    case 4: resultado = valorEmPascal / 133.322; break; // mmHg
                }
                resultadoTexto = resultado.ToString("N4");
            }
            // Potência
            else if (tipoConversao.Valor == 10)
            {
                var unidadeOrigem = cbConversorCalculadoraUnidade1.SelectedItem as Conversor;
                var unidadeDestino = cbConversorCalculadoraUnidade2.SelectedItem as Conversor;
                if (unidadeOrigem == null || unidadeDestino == null || unidadeOrigem.Valor == 0 || unidadeDestino.Valor == 0)
                {
                    MessageBox.Show("Selecione as unidades de potência.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Converte tudo para Watt
                double valorEmWatt = valorEntrada;
                switch (unidadeOrigem.Valor)
                {
                    case 1: valorEmWatt = valorEntrada; break; // Watt
                    case 2: valorEmWatt = valorEntrada * 1000; break; // Quilowatt
                    case 3: valorEmWatt = valorEntrada * 735.49875; break; // Cavalo-vapor
                }
                // Converte de Watt para destino
                switch (unidadeDestino.Valor)
                {
                    case 1: resultado = valorEmWatt; break; // Watt
                    case 2: resultado = valorEmWatt / 1000; break; // Quilowatt
                    case 3: resultado = valorEmWatt / 735.49875; break; // Cavalo-vapor
                }
                resultadoTexto = resultado.ToString("N4");
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
            else if (conversor.Valor == 4) // Massa
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipoM1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoM2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
                cbConversorCalculadoraUnidade2.Enabled = true;
            }
            else if (conversor.Valor == 5) // Tempo
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipoTem1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoTem2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
                cbConversorCalculadoraUnidade2.Enabled = true;
            }
            else if (conversor.Valor == 6) // Área
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipoA1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoA2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
                cbConversorCalculadoraUnidade2.Enabled = true;
            }
            else if (conversor.Valor == 7) // Volume
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipoV1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoV2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
                cbConversorCalculadoraUnidade2.Enabled = true;
            }
            else if (conversor.Valor == 8) // Velocidade
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipoVel1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoVel2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
                cbConversorCalculadoraUnidade2.Enabled = true;
            }
            else if (conversor.Valor == 9) // Pressão
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipoP1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoP2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
                cbConversorCalculadoraUnidade2.Enabled = true;
            }
            else if (conversor.Valor == 10) // Potência
            {
                cbConversorCalculadoraUnidade1.DataSource = Conversor.TipoPot1Conversao;
                cbConversorCalculadoraUnidade1.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade1.ValueMember = "Valor";
                cbConversorCalculadoraUnidade2.DataSource = Conversor.TipoPot2Conversao;
                cbConversorCalculadoraUnidade2.DisplayMember = "Texto";
                cbConversorCalculadoraUnidade2.ValueMember = "Valor";
                cbConversorCalculadoraUnidade1.Enabled = true;
                cbConversorCalculadoraUnidade2.Enabled = true;
            }

        }

        private void btConversorCalculadoraInverter_Click(object sender, EventArgs e)
        {
            int tipoSelecionado = cbConversorCalculadoraTipo.SelectedIndex;

            if (tipoSelecionado != 2)
            {
                // Inversão simples para os modos 1 e 3
                int idx1 = cbConversorCalculadoraUnidade1.SelectedIndex;
                int idx2 = cbConversorCalculadoraUnidade2.SelectedIndex;

                cbConversorCalculadoraUnidade1.SelectedIndex = idx2;
                cbConversorCalculadoraUnidade2.SelectedIndex = idx1;
            }
            else
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
