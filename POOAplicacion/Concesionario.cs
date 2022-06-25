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
        
        public void AñadirCoche()
        {
            Console.WriteLine("Escribe la marca:");
            Coche coche = new Coche();
            coche.marca = Console.ReadLine();
            Console.WriteLine("Escribe el modelo:");
            coche.modelo = Console.ReadLine();
            Console.WriteLine("Escribe el kilometraje:");
            string KM = Console.ReadLine();
            coche.km = int.Parse(KM);
            Console.WriteLine("Escribe el precio:");
            string PRECIO = Console.ReadLine();
            coche.precio = int.Parse(PRECIO);
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
        public 
    }
}
