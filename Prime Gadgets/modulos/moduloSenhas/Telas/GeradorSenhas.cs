using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloSenhas
{
    public partial class GeradorSenhas : Form
    {
        public GeradorSenhas()
        {
            InitializeComponent();
            Load += GeradorSenhas_Load;
        }

        private void btGeradorSenhasCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btGeradorSenhasSalvar_Click(object sender, EventArgs e)
        {
            SenhaPreferences.comprimento = tbGeradorSenhasComprimento.Value;
            SenhaPreferences.letraMa = cbGeradorSenhasLetrasMa.Checked;
            SenhaPreferences.letraMi = cbGeradorSenhasLetrasMi.Checked;
            SenhaPreferences.CaracterEs = cbGeradorSenhasCaracterEs.Checked;
            SenhaPreferences.Salvar();
            this.Dispose();
        }

        private void tbGerarSenhasComprimento_Scroll(object sender, EventArgs e)
        {
            lbGeradorSenhasComprimentoNumber.Text = tbGeradorSenhasComprimento.Value.ToString();
        }

        private void GeradorSenhas_Load(object sender, EventArgs e)
        {
            SenhaPreferences.Carregar();
            cbGeradorSenhasLetrasMa.Checked = SenhaPreferences.letraMa;
            cbGeradorSenhasLetrasMi.Checked = SenhaPreferences.letraMi;
            cbGeradorSenhasCaracterEs.Checked = SenhaPreferences.CaracterEs;
            tbGeradorSenhasComprimento.Value = Math.Min(
                Math.Max(tbGeradorSenhasComprimento.Minimum, SenhaPreferences.comprimento),
                tbGeradorSenhasComprimento.Maximum);
            lbGeradorSenhasComprimentoNumber.Text = SenhaPreferences.comprimento.ToString();
        }
    }

    public static class SenhaPreferences
    {
        public static bool letraMa = true;
        public static bool letraMi = true;
        public static bool CaracterEs = true;
        public static int comprimento = 8;

        private static readonly string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "senha_config.json");

        public static void Salvar()
        {
            var dir = Path.GetDirectoryName(configPath);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            var config = new
            {
                letraMa,
                letraMi,
                CaracterEs,
                comprimento
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(configPath, JsonSerializer.Serialize(config, options));
        }

        public static void Carregar()
        {
            if (!File.Exists(configPath))
                return;

            var json = File.ReadAllText(configPath);
            var config = JsonSerializer.Deserialize<SenhaConfigDto>(json);
            if (config != null)
            {
                letraMa = config.letraMa;
                letraMi = config.letraMi;
                CaracterEs = config.CaracterEs;
                comprimento = config.comprimento;
            }
        }

        private class SenhaConfigDto
        {
            public bool letraMa { get; set; }
            public bool letraMi { get; set; }
            public bool CaracterEs { get; set; }
            public int comprimento { get; set; }
        }
    }
}