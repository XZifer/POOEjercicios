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
            int[] numeros = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                numeros[i] = randomEntreNumeros(min,max);   
            }
            return numeros;
        }
        public int[] randomEntreNumerosSinRepetir(int tamaño,int min, int max)
        {
            if (min > max)
            {
                int cambiar = min;
                min = max;
                max = cambiar;
            }
            if (tamaño <= 0 || tamaño < max-min)
            {
                return null;
            }
            int[] numeros = new int[tamaño];
            bool repetido;
            int indicenumeros = 0;
            int numero;

            while (indicenumeros < tamaño)
            {
                repetido = false;
                numero = randomEntreNumeros(min, max);
                for (int i = 0; i < indicenumeros; i++)
                {
                    if (numeros[i] == numero)
                    {
                        repetido = true;
                    }

                    
                };
                if (!repetido)
                {
                    numeros[indicenumeros] = numero;
                    indicenumeros++;
                }
            }

            return numeros;
            
        }
    }
}
