using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAplicacion
{
    public class Coche
    {
        private int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int km { get; set; }
        public double precio { get; set; }

        public string ToString()
        {
            return "Detalles\n"+Marca+"\n"+Modelo+"\n"+km+"kms\n"+"$"+precio;
        }
    }
}
