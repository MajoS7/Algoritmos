using System;

namespace FuncionCuadratica
{
    class Program
    {
        static void Main()
        {
            //Realizar un algoritmo que me permita resolver una funcion cuadratica AX^2 + BX + C.

            Console.Write("Calcula la Funcion cuadratica AX^2+BX+C\nDigite el valor de A: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite el valor de B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite el valor de X: ");
            double X = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite el valor de C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            double quadraticFunction = A * Math.Pow(X, 2) + B * X + C;
            Console.Write($"\tFuncion Cuadratica\nA={A}\nB={B}\nX={X}\nC={C}\nFC={A}({X}^2)+{B}({X})+{C} = {quadraticFunction}");

        }
    }
}
