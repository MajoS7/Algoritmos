using System;
using System.Collections.Generic;

namespace ConversionDecimal
{
    class Program
    {
        static void Main()
        {
            //Realizar un programa en C# que convierta un número del sistema de base 2 al sistema decimal.
            Console.Write("Digite un numero Binario: ");
            string binario = Console.ReadLine();
            int cantidad = binario.Length;

            int[] lista = new int[cantidad];

            int contador = 0;
            foreach (char item in binario)
            {
                lista[contador]=item;
                contador = contador + 1;
            }

            contador = 0;
            double numberdecimal = 0;

            foreach (int i in lista)
            {
                
                
                if (Convert.ToInt32(i) == 49)
                {
                    numberdecimal = numberdecimal + Math.Pow(2, contador);
                }
                contador = contador + 1;
            }


            Console.WriteLine(numberdecimal); 

        }
    }
}
