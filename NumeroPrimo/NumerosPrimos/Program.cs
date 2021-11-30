using System;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dado un numero imprima si es un numero primo o no

            Console.Write("Ingrese un numero: ");

            decimal Number = Convert.ToDecimal(Console.ReadLine());

            int Contador = 1;

            int NumeroDivisiones = 0;

            while (Contador <= Number)
            {
                
                if (Number% Contador == 0)
                {
                    NumeroDivisiones = NumeroDivisiones + 1;
                }
                Contador = Contador +1;
            }

            if (NumeroDivisiones == 2)
            {
                Console.Write("El " + Number + " es primo");
            }
            else
            {
                Console.WriteLine("El " + Number + " no es primo");
            }

        }
    }
}
