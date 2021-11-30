using System;

namespace Multiplicacion3numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que ingresados 3 numeros me permita multiplicarlos numeros.
            Console.Write("Numero 1: ");
            decimal numberOne = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Numero 2: ");
            decimal numberTwo = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Numero 3: ");
            decimal numberThree = Convert.ToDecimal(Console.ReadLine());

            decimal multiplication = numberOne * numberTwo * numberThree;

            Console.Write($"Multiplicacion: {numberOne}*{numberTwo}*{numberThree} = {multiplication}");

            
        }
    }
}
