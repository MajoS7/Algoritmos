using System;

namespace NumeroCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que me permita elevar un numero al cubo.
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

            double numberCube = Math.Pow(number, 3); 

            Console.Write($"{number}^3 = {numberCube}");
        }
    }
}
