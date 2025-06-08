using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Gadgets.modulos.moduloSenhas
{
    public static class SenhaConfig
    {
        public static int comprimento { get; set; } = 8;
        public static bool letraMa { get; set; } = true;
        public static bool letraMi { get; set; } = true;
        public static bool CaracterEs { get; set; } = true;
    }
}
