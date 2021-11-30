using System;

namespace TeoremaPitagoras
{
    class Program
    {
        static void Main()
        {
            //Realizar un algoritmo que me calcule la hipotenusa de un triangulo, dados sus 2 catetos

            Console.Write("Digite el cateto 1: ");
            double redneckOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite el cateto 2: ");
            double redneckTwo = Convert.ToDouble(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(redneckOne, 2) + Math.Pow(redneckTwo, 2));

            Console.WriteLine($"La hipotenusa es √{redneckOne}^2+{redneckTwo}^2 = {hypotenuse}");


        }
    }
}
