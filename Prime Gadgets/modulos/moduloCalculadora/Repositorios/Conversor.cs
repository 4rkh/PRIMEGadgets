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
            new Conversor { Texto = "Numérico", Valor = 3 },
            new Conversor { Texto = "Massa", Valor = 4 },
            new Conversor { Texto = "Tempo", Valor = 5 },
            new Conversor { Texto = "Área", Valor = 6 },
            new Conversor { Texto = "Volume", Valor = 7 },
            new Conversor { Texto = "Velocidade", Valor = 8 },
            new Conversor { Texto = "Pressão", Valor = 9 },
            new Conversor { Texto = "Potência", Valor = 10 }
        };

        // Temperatura (já existente)
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

        // Distância (já existente)
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

        // Numérico (já existente)
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

        // Massa
        public static List<Conversor> TipoM1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de massa", Valor = 0},
            new Conversor { Texto = "Quilograma", Valor = 1 },
            new Conversor { Texto = "Grama", Valor = 2 },
            new Conversor { Texto = "Tonelada", Valor = 3 },
            new Conversor { Texto = "Libra", Valor = 4 },
            new Conversor { Texto = "Onça", Valor = 5 }
        };
        public static List<Conversor> TipoM2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de massa", Valor = 0},
            new Conversor { Texto = "Quilograma", Valor = 1 },
            new Conversor { Texto = "Grama", Valor = 2 },
            new Conversor { Texto = "Tonelada", Valor = 3 },
            new Conversor { Texto = "Libra", Valor = 4 },
            new Conversor { Texto = "Onça", Valor = 5 }
        };

        // Tempo
        public static List<Conversor> TipoTem1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de tempo", Valor = 0},
            new Conversor { Texto = "Segundo", Valor = 1 },
            new Conversor { Texto = "Minuto", Valor = 2 },
            new Conversor { Texto = "Hora", Valor = 3 },
            new Conversor { Texto = "Dia", Valor = 4 }
        };
        public static List<Conversor> TipoTem2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de tempo", Valor = 0},
            new Conversor { Texto = "Segundo", Valor = 1 },
            new Conversor { Texto = "Minuto", Valor = 2 },
            new Conversor { Texto = "Hora", Valor = 3 },
            new Conversor { Texto = "Dia", Valor = 4 }
        };

        // Área
        public static List<Conversor> TipoA1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de área", Valor = 0},
            new Conversor { Texto = "Metro quadrado", Valor = 1 },
            new Conversor { Texto = "Quilômetro quadrado", Valor = 2 },
            new Conversor { Texto = "Hectare", Valor = 3 },
            new Conversor { Texto = "Acre", Valor = 4 }
        };
        public static List<Conversor> TipoA2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de área", Valor = 0},
            new Conversor { Texto = "Metro quadrado", Valor = 1 },
            new Conversor { Texto = "Quilômetro quadrado", Valor = 2 },
            new Conversor { Texto = "Hectare", Valor = 3 },
            new Conversor { Texto = "Acre", Valor = 4 }
        };
        // Volume
        public static List<Conversor> TipoV1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de volume", Valor = 0 },
            new Conversor { Texto = "Litro", Valor = 1 },
            new Conversor { Texto = "Mililitro", Valor = 2 },
            new Conversor { Texto = "Metro cúbico", Valor = 3 },
            new Conversor { Texto = "Galão", Valor = 4 }
        };
        public static List<Conversor> TipoV2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de volume", Valor = 0 },
            new Conversor { Texto = "Litro", Valor = 1 },
            new Conversor { Texto = "Mililitro", Valor = 2 },
            new Conversor { Texto = "Metro cúbico", Valor = 3 },
            new Conversor { Texto = "Galão", Valor = 4 }
        };
        public static List<Conversor> TipoVel1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de velocidade", Valor = 0 },
            new Conversor { Texto = "m/s", Valor = 1 },
            new Conversor { Texto = "km/h", Valor = 2 },
            new Conversor { Texto = "mph", Valor = 3 },
            new Conversor { Texto = "nó", Valor = 4 }
        };
        public static List<Conversor> TipoVel2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de velocidade", Valor = 0 },
            new Conversor { Texto = "m/s", Valor = 1 },
            new Conversor { Texto = "km/h", Valor = 2 },
            new Conversor { Texto = "mph", Valor = 3 },
            new Conversor { Texto = "nó", Valor = 4 }
        };
        // Pressão
        public static List<Conversor> TipoP1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de pressão", Valor = 0 },
            new Conversor { Texto = "Pascal", Valor = 1 },
            new Conversor { Texto = "Bar", Valor = 2 },
            new Conversor { Texto = "Atmosfera", Valor = 3 },
            new Conversor { Texto = "mmHg", Valor = 4 }
        };
        public static List<Conversor> TipoP2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de pressão", Valor = 0 },
            new Conversor { Texto = "Pascal", Valor = 1 },
            new Conversor { Texto = "Bar", Valor = 2 },
            new Conversor { Texto = "Atmosfera", Valor = 3 },
            new Conversor { Texto = "mmHg", Valor = 4 }
        };
        // Potência
        public static List<Conversor> TipoPot1Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de potência", Valor = 0 },
            new Conversor { Texto = "Watt", Valor = 1 },
            new Conversor { Texto = "Quilowatt", Valor = 2 },
            new Conversor { Texto = "Cavalo-vapor", Valor = 3 }
        };
        public static List<Conversor> TipoPot2Conversao = new List<Conversor>
        {
            new Conversor { Texto = "Selecione a unidade de potência", Valor = 0 },
            new Conversor { Texto = "Watt", Valor = 1 },
            new Conversor { Texto = "Quilowatt", Valor = 2 },
            new Conversor { Texto = "Cavalo-vapor", Valor = 3 }
        };
        public static List<Conversor> ConversaoBloqueada = new List<Conversor>
        {
            new Conversor { Texto = "Selecione o tipo de conversão!"},
        };
    }
}
