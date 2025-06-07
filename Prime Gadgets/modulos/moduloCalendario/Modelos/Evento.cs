using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Gadgets.modulos.moduloCalendario
{
    public class Evento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; } = "";
        public string Descricao { get; set; } = "";
    }
}
