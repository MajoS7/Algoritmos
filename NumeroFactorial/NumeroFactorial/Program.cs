using System;

namespace NumeroFactorial
{
    class Program
    {
        static void Main()
        {
            //Realizar un algoritmo que dado un numero me permita calcular su factorial.
            bool check = false;
            int number = 0;

            while (check != true)
            {
                try
                {
                    Console.Write("Digite el numero: ");
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
            int factorial = 1;
            string text = "";

            for (int i =1; i<=number; i++)
            {
                factorial = factorial * i;
                text = text + $" * {i}";
            }

            Console.WriteLine(text + $" = {factorial}");



        }
    }
}
