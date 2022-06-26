using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAplicacion
{
    internal class Ordenador
    {
        public int tamañoDisco { get; set; }
        public int tamañoDiscoMax { get; set; }
        public bool encendido { get; set; }

        public void encender()
        {
            encendido = true;
        }
        public void apagar()
        {
            encendido = false;
        }
    }
}
