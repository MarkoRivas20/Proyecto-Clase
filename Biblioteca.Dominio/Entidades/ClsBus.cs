using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    public class ClsBus
    {
        public string Placa { get; private set; }
        public string Tamaño { get; private set; }
        public string Capacidad { get; set; }
        public string Fecha { get; set; }

        public string Estado { get; set; }
        public string linea { get; set; }
    }
}
