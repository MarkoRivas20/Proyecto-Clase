using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    public class ClsEmpleado
    {
        
        public string codempleado { get; set; }
        public string claveemp { get; private set; }
        public string nombreemp { get; private set; }
        public string apellidosemp { get; private set; }
        public string emailemp { get; private set; }
        public string telefonoemp { get; private set; }
        public string cargoemp { get; private set; }
        public string estadoemp { get; private set; }
        public string nrolicencia { get; set; }
        public string tipolicencia { get; set; }
    }
}
