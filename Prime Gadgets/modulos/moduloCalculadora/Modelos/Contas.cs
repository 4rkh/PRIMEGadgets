using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Gadgets.modulos.moduloCalculadora
{
    public class Contas
    {
        public int Id { get; set; }
        public double Numero1 { get; set; } = 0;
        public string Operador { get; set; } = "";
        public double Numero2 { get; set; } = 0;
        public double Resultado { get; set; } = 0;

    }
}
