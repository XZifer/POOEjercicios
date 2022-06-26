using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAplicacion
{
    internal class Concesionario
    {
        public List<Coche> coches { get; set; }

        public Concesionario()
        {
            coches = new List<Coche>();
            //Coche coche1 = new Coche();
            //coche1.id = 1;
            //coche1.marca = "M"
        }
        
        public void AñadirCoche(Coche c)
        {
            c.id = coches.Count + 1;
            coches.Add(c);
            
        }
        public void MostrarCoches()
        {
            foreach (Coche c in coches)
            {
                Console.WriteLine(c.ToString());
            }             
        }
        public  void VaciarCoches()
        {
            coches.Clear();
        }
        public void EliminarCoche(Coche c)
        {
            for (int i = 0; i < coches.Count; i++)
            {
                if (coches[i] == c)
                {
                    coches.Remove(coches[i]);
                    for (int j = 0; j < coches.Count; j++)
                    {
                        coches[j].id = j + 1;
                    }
                }
                else
                {
                    Console.WriteLine("No Existe");
                }
            }
        }
    }
}
