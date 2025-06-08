using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Gadgets.modulos.moduloFinanceiro
{
    internal class Gasto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Categoria { get; set; } // Ex: Alimentação, Transporte, etc.
        public string FormaPagamento { get; set; } // Ex: Cartão de Crédito, Dinheiro, etc.
        public string Observacoes { get; set; } // Campo opcional para anotações adicionais
    }
}
