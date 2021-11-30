using System;

namespace Multiplos5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que dado un numero, me permita realizar la sumatoria de los multiplos de 5 que 
            hay entre 1 y el numero dado.  Ej: si el numero es 25, debe sumar asi 5 + 10 + 15 + 20 + 25 e imprimir 
            el resultado.*/

            bool check = false;
            int number = 0;

            while (check != true)
            {
                try
                {
                    Console.Write("Digite un numero: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number > 0)
                    {
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("El numero debe ser un entero positivo");
                    }

                }
                catch
                {
                    Console.WriteLine("El numero debe ser un entero positivo");
                }


            }
            int sum = 0;
            string text="";

            for (int i= 5; i<=number; i++)
            {
                if (i % 5 == 0)
                {
                    sum = sum + i;
                    text = text + $"+{i}";
                }
            }

            Console.Write(text + $" = {sum}");

        }
    }
}
