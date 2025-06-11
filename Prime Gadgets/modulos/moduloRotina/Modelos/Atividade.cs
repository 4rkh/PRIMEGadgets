using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Gadgets.modulos.moduloRotina
{
    public class Atividade
    {
        public DayOfWeek DiaDaSemana { get; set; }
        public string Nome { get; set; } = "";
        public TimeOnly Horario { get; set; }
        
    }
}
