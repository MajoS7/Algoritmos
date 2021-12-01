using System;

namespace Suma2Numeros
{
    class Program
    {
        static void Main()
        {
            //Pedir 2 números por teclado y sumarlos.
            Console.Write("Ingrese el numero 1: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el numero 2: ");
            int numbertwo = Convert.ToInt32(Console.ReadLine());

            int sum = numberOne + numbertwo;
            Console.WriteLine($"{numberOne}+{numbertwo}={sum}");
        }
    }
}
