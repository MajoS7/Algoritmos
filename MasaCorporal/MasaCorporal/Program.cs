using System;

namespace MasaCorporal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que pida el peso, la estatura y muestre el índice de la masa corporal.
            //➢	Fórmula: Peso / Estatura ^ 2
            Console.Write("Digite su peso en Kilogramos: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite su estatura en Metros: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bodyMass = weight / Math.Pow(height, 2);

            Console.WriteLine($"Su masa corporal es de {bodyMass}");


        }
    }
}
