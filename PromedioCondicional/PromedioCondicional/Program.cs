using System;

namespace PromedioCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que pida tres notas de un alumno, calcule el promedio e imprima lo siguiente:
            //➢	Si el promedio es > 10 mostrar "Aprobado".
            //➢	Si el promedio es > 7 y <= 9 mostrar "Desaprobado".
            //➢	Si el promedio es< 7 mostrar "Reprobado".
            Console.Write("Digite la nota uno: ");
            double noteOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite la nota dos: ");
            double noteTwo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite la nota tres: ");
            double noteThree = Convert.ToDouble(Console.ReadLine());

            double average = (noteOne + noteTwo + noteThree) / 3;

            if (average > 10)
            {
                Console.WriteLine($"Nota: {average}\nResultado: Aprobado");
            }
            else if( average > 7 && average <= 9)
            {
                Console.WriteLine($"Nota: {average}\nResultado: Desaprobado");
            }
            else if (average<7)
            {
                Console.WriteLine($"Nota: {average}\nResultado: Reprobado");
            }

        }
    }
}
