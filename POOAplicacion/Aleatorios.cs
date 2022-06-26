using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAplicacion
{
    class Aleatorios
    {
        public Random random { get; set; }

        public Aleatorios()
        {
            random = new Random();
        }

        public int randomEntreNumeros(int min,int max)
        {
            if (min > max)
            {
                int cambiar = min;
                min = max;
                max = cambiar;
            }
            return random.Next(min,max +1);
        }
        public int[] ArraydeNumRandom(int tamaño,int min,int max)
        {
            if (tamaño <= 0)
            {
                return null;
            }
            int[] array = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                array[i] = randomEntreNumeros(min,max);   
            }
            return array;
        }
    }
}
