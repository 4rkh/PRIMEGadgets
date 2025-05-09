using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prime_Gadgets.modulos.moduloContatos;

namespace Prime_Gadgets.modulos.moduloCalendario
{
    public class Evento
    {
        public int Id { get; set; }
        public string Data { get; set; } = "";
        public string Local { get; set; } = "";
        public string Descricao { get; set; } = "";
        public Contatos Contato { get; set; } = new Contatos();
    }
}
