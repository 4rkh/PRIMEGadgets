using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Gadgets.modulos.moduloCalculadora
{
    public class Conversor
    {
        public string Texto { get; set; }
        public int Valor { get; set; }

        public static List<Conversor> TiposConversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de conversão", Valor = 0},
            new Conversor { Texto = "Temperatura", Valor = 1 },
            new Conversor { Texto = "Distância", Valor = 2 },
            new Conversor { Texto = "Numérico", Valor = 3 }
        };
        public static List<Conversor> TipoT1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de temperatura", Valor = 0},
            new Conversor { Texto = "Celsius", Valor = 1 },
            new Conversor { Texto = "Fahrenheit", Valor = 2 },
            new Conversor { Texto = "Kelvin", Valor = 3 }
        };
        public static List<Conversor> TipoT2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de temperatura", Valor = 0},
            new Conversor { Texto = "Celsius", Valor = 1 },
            new Conversor { Texto = "Fahrenheit", Valor = 2 },
            new Conversor { Texto = "Kelvin", Valor = 3 }
        };
        public static List<Conversor> TipoD1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de distância", Valor = 0},
            new Conversor { Texto = "Quilomêtros", Valor = 1 },
            new Conversor { Texto = "Milhas", Valor = 2 }
        };
        public static List<Conversor> TipoD2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de distância", Valor = 0},
            new Conversor { Texto = "Quilomêtros", Valor = 1 },
            new Conversor { Texto = "Milhas", Valor = 2 }
        };
        public static List<Conversor> TipoC1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo numérico", Valor = 0},
            new Conversor { Texto = "Binário", Valor = 1 },
            new Conversor { Texto = "Decimal", Valor = 2 }
        };
        public static List<Conversor> TipoC2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de distância", Valor = 0},
            new Conversor { Texto = "Binário", Valor = 1 },
            new Conversor { Texto = "Decimal", Valor = 2 }
        };
        public static List<Conversor> ConversaoBloqueada = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de conversão!"},
        };
    }
}
