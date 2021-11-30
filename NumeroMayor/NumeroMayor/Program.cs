using System;

namespace NumeroMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que me permita digitar 2 numeros y me indique cual es el mayor de ambos.
            Console.Write("Digite el numero 1: ");
            double numberOne = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite el numero 2: ");
            double numberTwo = Convert.ToDouble(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.Write($"El numero {numberOne} es el mayor");
            }
            else
            {
                Console.Write($"El numero {numberTwo} es el mayor");

            }
        }
    }
}
