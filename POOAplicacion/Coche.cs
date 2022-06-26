using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAplicacion
{
    public class Coche
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int km { get; set; }
        public double precio { get; set; }

        public override string ToString()
        {
            return "Detalles\n"+marca+"\n"+modelo+"\n"+km+"kms\n"+"$"+precio;
        }
    }
}
