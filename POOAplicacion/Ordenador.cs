using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAplicacion
{
    internal class Ordenador
    {
        public int tamañoDiscoGB { get; set; }
        public int tamañoDiscoMaxGB { get; set; }
        public bool encendido { get; set; }

        private const int tamañoPorDefecto = 100;
        public Ordenador()
        {
            tamañoDiscoGB = 0;
            encendido = false;
            if (tamañoDiscoMaxGB <= tamañoDiscoGB)
            {
                tamañoDiscoMaxGB = tamañoPorDefecto;
            }
        }

        public void encender()
        {
            encendido = true;
        }
        public void apagar()
        {
            encendido = false;
        }
        public void AñadirDatos(int datos)
        {
            if (encendido)
            {
                if ((tamañoDiscoGB + datos) > tamañoDiscoMaxGB)
                {
                    tamañoDiscoGB = tamañoDiscoMaxGB;
                }
                else
                {
                    tamañoDiscoGB += datos;
                }
            }
        }
        public void EliminarDatos(int datos)
        {
            if (datos > tamañoDiscoGB)
            {
                tamañoDiscoGB = 0;
            }
            else
            {
                tamañoDiscoGB -= datos;
            }
        }
    }
}
