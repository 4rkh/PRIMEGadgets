using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prime_Gadgets.modulos.moduloSenhas;
using Prime_Gadgets.modulos.moduloHome;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Prime_Gadgets.modulos.moduloCalculadora
{
    public partial class MainCalculadora : Form
    {
        public MainCalculadora()
        {
            InitializeComponent();
            this.AcceptButton = null;
        }
        private void CorrecaoEnter()
        {
            this.ActiveControl = campMainCalculadoraResult;
            campMainCalculadoraResult.SelectionStart = campMainCalculadoraResult.Text.Length;
            campMainCalculadoraResult.SelectionLength = 0;
        }

        private void btMainCalculadoraReturn_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            telaAtual.Close();
        }

        private void btMainCalculadoraHistory_Click(object sender, EventArgs e)
        {
            HistoricoCalculadora historicoCalculadora = new HistoricoCalculadora();
            historicoCalculadora.ShowDialog();
        }

        Bitmap btmOntop = Properties.Resources.ontop;
        Bitmap btmOfftop = Properties.Resources.offtop;
        private void btMainCalculadoraOntop_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
                btMainCalculadoraOntop.Image = btmOntop;
            }
            else
            {
                this.TopMost = true;
                btMainCalculadoraOntop.Image = btmOfftop;
            }
        }

        private void btMainCalculadoraPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string conta = Clipboard.GetText();

                if (System.Text.RegularExpressions.Regex.IsMatch(conta, @"^\s*\d+(\.\d+)?\s*$"))
                {
                    campMainCalculadoraResult.Text = conta;
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(conta, @"^\s*\d+(\.\d+)?\s*[\+\-\*/]\s*\d+(\.\d+)?\s*$"))
                {
                    campMainCalculadoraResult.Text = conta;
                }
                else
                {
                    campMainCalculadoraResult.Text = "Entrada inválida";
                }
            }
            else
            {
                campMainCalculadoraResult.Text = "Sem entradas detectadas";
            }
        }

        private void btMainCalculadoraConversor_Click(object sender, EventArgs e)
        {
            ConversorCalculadora conversorCalculadora = new ConversorCalculadora();
            conversorCalculadora.ShowDialog();
        }

        private void btMainCalculadoraSum_Click(object sender, EventArgs e)
        {
            string conta = campMainCalculadoraResult.Text;

            if (Regex.IsMatch(conta, @"^\s*\d+(,\d+)?\s*$"))
            {
                campMainCalculadoraResult.Text += " + ";
            }
            CorrecaoEnter();
        }

        private void btMainCalculadoraSubtraction_Click(object sender, EventArgs e)
        {
            string conta = campMainCalculadoraResult.Text;

            if (Regex.IsMatch(conta, @"^\s*\d+(,\d+)?\s*$"))
            {
                campMainCalculadoraResult.Text += " - ";
            }
            CorrecaoEnter();
        }

        private void btMainCalculadoraMultiplication_Click(object sender, EventArgs e)
        {
            string conta = campMainCalculadoraResult.Text;

            if (Regex.IsMatch(conta, @"^\s*\d+(,\d+)?\s*$"))
            {
                campMainCalculadoraResult.Text += " * ";
            }
            CorrecaoEnter();
        }

        private void btMainCalculadoraDivision_Click(object sender, EventArgs e)
        {
            string conta = campMainCalculadoraResult.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(conta, @"^\s*\d+(,\d+)?\s*$"))
            {
                campMainCalculadoraResult.Text += " / ";
            }
            CorrecaoEnter();
        }

        private void btMainCalculadora0_Click(object sender, EventArgs e)
        {
            if (campMainCalculadoraResult.Text.Contains("="))
            {
                campMainCalculadoraResult.Text = "0";
            }
            if(campMainCalculadoraResult.Text != "0")
            {
                campMainCalculadoraResult.Text += 0;
            }
            CorrecaoEnter();
        }

        private void btMainCalculadora1_Click(object sender, EventArgs e)
        {
            if (campMainCalculadoraResult.Text.Contains("="))
            {
                campMainCalculadoraResult.Text = "0";
            }
            if (campMainCalculadoraResult.Text == "0")
            {
                campMainCalculadoraResult.Text = "1";
            }
            else
            {
                campMainCalculadoraResult.Text += 1;
            }
            CorrecaoEnter();
        }

        private void btMainCalculadora2_Click(object sender, EventArgs e)
        {
            if (campMainCalculadoraResult.Text.Contains("="))
            {
                campMainCalculadoraResult.Text = "0";
            }
            if (campMainCalculadoraResult.Text == "0")
            {
                campMainCalculadoraResult.Text = "2";
            }
            else
            {
                campMainCalculadoraResult.Text += 2;
            }
            CorrecaoEnter();
        }

        private void btMainCalculadora3_Click(object sender, EventArgs e)
        {
            if (campMainCalculadoraResult.Text.Contains("="))
            {
                campMainCalculadoraResult.Text = "0";
            }
            if (campMainCalculadoraResult.Text == "0")
            {
                campMainCalculadoraResult.Text = "3";
            }
            else
            {
                campMainCalculadoraResult.Text += 3;
            }
            CorrecaoEnter();
        }

        private void btMainCalculadora4_Click(object sender, EventArgs e)
        {
            if (campMainCalculadoraResult.Text.Contains("="))
            {
                campMainCalculadoraResult.Text = "0";
            }
            if (campMainCalculadoraResult.Text == "0")
            {
                campMainCalculadoraResult.Text = "4";
            }
            else
            {
                campMainCalculadoraResult.Text += 4;
            }
            CorrecaoEnter();
        }

        private void btMainCalculadora5_Click(object sender, EventArgs e)
        {
            if (campMainCalculadoraResult.Text.Contains("="))
            {
                campMainCalculadoraResult.Text = "0";
            }
            if (campMainCalculadoraResult.Text == "0")
            {
                campMainCalculadoraResult.Text = "5";
            }
            else
            {
                campMainCalculadoraResult.Text += 5;
            }
            CorrecaoEnter();
        }

        private void btMainCalculadora6_Click(object sender, EventArgs e)
        {
            if (campMainCalculadoraResult.Text.Contains("="))
            {
                campMainCalculadoraResult.Text = "0";
            }
            if (campMainCalculadoraResult.Text == "0")
            {
                campMainCalculadoraResult.Text = "6";
            }
            else
            {
                campMainCalculadoraResult.Text += 6;
            }
            CorrecaoEnter();
        }

        private void btMainCalculadora7_Click(object sender, EventArgs e)
        {
            if (campMainCalculadoraResult.Text.Contains("="))
            {
                campMainCalculadoraResult.Text = "0";
            }
            if (campMainCalculadoraResult.Text == "0")
            {
                campMainCalculadoraResult.Text = "7";
            }
            else
            {
                campMainCalculadoraResult.Text += 7;
            }
            CorrecaoEnter();
        }

        private void btMainCalculadora8_Click(object sender, EventArgs e)
        {
            if (campMainCalculadoraResult.Text.Contains("="))
            {
                campMainCalculadoraResult.Text = "0";
            }
            if (campMainCalculadoraResult.Text == "0")
            {
                campMainCalculadoraResult.Text = "8";
            }
            else
            {
                campMainCalculadoraResult.Text += 8;
            }
            CorrecaoEnter();
        }

        private void btMainCalculadora9_Click(object sender, EventArgs e)
        {
            if (campMainCalculadoraResult.Text.Contains("="))
            {
                campMainCalculadoraResult.Text = "0";
            }
            if (campMainCalculadoraResult.Text == "0")
            {
                campMainCalculadoraResult.Text = "9";
            }
            else
            {
                campMainCalculadoraResult.Text += 9;
            }
            CorrecaoEnter();
        }

        private void btMainCalculadoraComma_Click(object sender, EventArgs e)
        {
            string conta = campMainCalculadoraResult.Text;

            // Se estiver vazio ou terminar com operador, adicione "0,"
            if (string.IsNullOrEmpty(conta) || conta.EndsWith("+") || conta.EndsWith("-") || conta.EndsWith("*") || conta.EndsWith("/"))
            {
                campMainCalculadoraResult.Text += "0,";
                return;
            }

            // Divide a conta e pega o último número após o último operador
            string[] partes = Regex.Split(conta, @"[+\-*/]");
            string ultimoNumero = partes[partes.Length - 1];

            // Verifica se já tem vírgula no número atual e se ele contém dígitos
            bool contemNumero = Regex.IsMatch(ultimoNumero, @"\d");

            if (!ultimoNumero.Contains(",") && contemNumero)
            {
                campMainCalculadoraResult.Text += ",";
            }
            CorrecaoEnter();
        }


        private void btMainCalculadoraClear_Click(object sender, EventArgs e)
        {
            campMainCalculadoraResult.Text = "";
            CorrecaoEnter();
        }

        private void btMainCalculadoraEnter_Click(object sender, EventArgs e)
        {
            string padrao = @"(\d+(\.\d+)?)\s*([\+\-\*/])\s*(\d+(\.\d+)?)";
            string conta = campMainCalculadoraResult.Text.Replace(",", ".");
            Match match = Regex.Match(conta, padrao);

            if (match.Success)
            {
                double numero1 = double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
                double numero2 = double.Parse(match.Groups[4].Value, CultureInfo.InvariantCulture);
                double resultado = 0;

                string operador = match.Groups[3].Value;

                switch (operador)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;

                    case "-":
                        resultado = numero1 - numero2;
                        break;

                    case "*":
                        resultado = numero1 * numero2;
                        break;
                    case "/":
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;

                        }
                        else
                        {
                            campMainCalculadoraResult.Text += " = " + "Não é possível dividir por zero";
                        }
                        break;
                    default:
                        MessageBox.Show("Operador inválido!");
                        return;
                }
                if (!conta.Contains("="))
                {
                    campMainCalculadoraResult.Text += " = " + resultado.ToString().Replace(".", ",");
                }
            }
            else if (!conta.Contains("=") && conta != "")
            {
                campMainCalculadoraResult.Text += " = " + conta;
            }
        }
        private void MainCalculadora_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(MainCalculadora_KeyDown);
        }
        private void MainCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            // Botão de soma (+)
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                btMainCalculadoraSum.PerformClick();
            }
            // Botão de subtração (-)
            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                btMainCalculadoraSubtraction.PerformClick();
            }
            // Botão de multiplicação (*)
            if (e.KeyCode == Keys.Multiply)
            {
                btMainCalculadoraMultiplication.PerformClick();
            }
            // Botão de divisão (/)
            if (e.KeyCode == Keys.Divide)
            {
                btMainCalculadoraDivision.PerformClick();
            }
            // Botão de zero (0)
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                btMainCalculadora0.PerformClick();
            }
            // Botão de um (1)
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                btMainCalculadora1.PerformClick();
            }
            // Botão de dois (2)
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                btMainCalculadora2.PerformClick();
            }
            // Botão de três (3)
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                btMainCalculadora3.PerformClick();
            }
            // Botão de quatro (4)
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                btMainCalculadora4.PerformClick();
            }
            // Botão de cinco (5)
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                btMainCalculadora5.PerformClick();
            }
            // Botão de seis (6)
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                btMainCalculadora6.PerformClick();
            }
            // Botão de sete (7)
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                btMainCalculadora7.PerformClick();
            }
            // Botão de oito (8)
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                btMainCalculadora8.PerformClick();
            }
            // Botão de nove (9)
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                btMainCalculadora9.PerformClick();
            }
            // Botão de vírgula (.)
            if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Oemcomma)
            {
                btMainCalculadoraComma.PerformClick();
            }
            // Botão de limpar (C)
            if (!e.Control && (e.KeyCode == Keys.Back || e.KeyCode == Keys.C))
            {
                btMainCalculadoraClear.PerformClick();
            }
            // Botão de enter (ENTER)
            if (e.KeyCode == Keys.Enter)
            {
                btMainCalculadoraEnter.PerformClick();
            }
            // Botão de voltar (ESC)
            if (e.KeyCode == Keys.Escape)
            {
                btMainCalculadoraReturn.PerformClick();
            }
            // Botão de histórico (CTRL + H)
            if (e.Control && e.KeyCode == Keys.H)
            {
                btMainCalculadoraHistory.PerformClick();
            }
            // Botão de conversor (CTRL + B)
            if (e.Control && e.KeyCode == Keys.B)
            {
                btMainCalculadoraConversor.PerformClick();
            }
            // Botão de paste (CTRL + V)
            if (e.Control && e.KeyCode == Keys.V)
            {
                btMainCalculadoraPaste.PerformClick();
            }
            // Botão de sempre por cima (CTRL + T)
            if (e.Control && e.KeyCode == Keys.T)
            {
                btMainCalculadoraOntop.PerformClick();
            }
        }
    }
}
