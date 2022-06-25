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
        
        public void AñadirCoche(string marca,string modelo,int km,double precio)
        {
            Coche coche = new Coche();
            coche.id = coches.Count + 1 ;
            coche.marca = marca;
            coche.modelo = modelo;
            coche.km = km;
            coche.precio = precio;
            coches.Add(coche);
        }
        public void MostrarCoches()
        {
            string coche;
            foreach (Coche c in coches)
            {
                coche = c.ToString();
                Console.WriteLine(coche);
            }             
        }
        public  void VaciarCoches()
        {
            coches.Clear();
        }
        public void EliminarCoche(Coche c)
        {
            coches.Remove(c);
        }
    }
}
