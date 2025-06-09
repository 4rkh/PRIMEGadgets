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
        public static List<Conversor> TipoCD1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de distância", Valor = 0},
            new Conversor { Texto = "Métrico", Valor = 1 },
            new Conversor { Texto = "Imperial", Valor = 2 }
        };
        public static List<Conversor> TipoCD2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de distância", Valor = 0},
            new Conversor { Texto = "Métrico", Valor = 1 },
            new Conversor { Texto = "Imperial", Valor = 2 }
        };
        public static List<Conversor> TipCI1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de distância", Valor = 0},
            new Conversor { Texto = "Polegada", Valor = 1 },
            new Conversor { Texto = "Pé", Valor = 2 },
            new Conversor { Texto = "Jarda", Valor = 3 },
            new Conversor { Texto = "Milha", Valor = 4 }
        };
        public static List<Conversor> TipoCI2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de distância", Valor = 0},
            new Conversor { Texto = "Polegada", Valor = 1 },
            new Conversor { Texto = "Pé", Valor = 2 },
            new Conversor { Texto = "Jarda", Valor = 3 },
            new Conversor { Texto = "Milha", Valor = 4 }
        };
        public static List<Conversor> TipoCM1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de distância", Valor = 0},
            new Conversor { Texto = "Milímetro", Valor = 1 },
            new Conversor { Texto = "Centímetro", Valor = 2 },
            new Conversor { Texto = "Metro", Valor = 3 },
            new Conversor { Texto = "Quilômetro", Valor = 4 }
        };
        public static List<Conversor> TipoCM2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de distância", Valor = 0},
            new Conversor { Texto = "Milímetro", Valor = 1 },
            new Conversor { Texto = "Centímetro", Valor = 2 },
            new Conversor { Texto = "Metro", Valor = 3 },
            new Conversor { Texto = "Quilômetro", Valor = 4 }
        };
        public static List<Conversor> TipoC1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo numérico", Valor = 0},
            new Conversor { Texto = "Binário", Valor = 1 },
            new Conversor { Texto = "Decimal", Valor = 2 },
            new Conversor { Texto = "Hexadecimal", Valor = 3 }
        };
        public static List<Conversor> TipoC2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo numérico", Valor = 0},
            new Conversor { Texto = "Binário", Valor = 1 },
            new Conversor { Texto = "Decimal", Valor = 2 },
            new Conversor { Texto = "Hexadecimal", Valor = 3 }
        };
        public static List<Conversor> ConversaoBloqueada = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de conversão!"},
        };
    }
}
