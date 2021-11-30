using System;

namespace Calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una calculadora con operaciones basicas con dos numeros
            Console.Write("numero 1: ");
            float Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("numero 2: ");
            float Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tiene las siguientes opciones: \n1. Suma \n2. Resta \n3. Multiplicación \n4.División");
            Console.Write("Digite por favor el numero de la opcion: ");
            int Opcion = Convert.ToInt32(Console.ReadLine());
            switch (Opcion)
            {
                case 1:
                    {
                        float Suma = Num1 + Num2;
                        Console.Write(Suma);
                        break;
                    }
                case 2:
                    {
                        float Resta = Num1 - Num2;
                        Console.Write(Resta);
                        break;
                    }

                case 3:
                    {
                        float Multiplicacion = Num1 * Num2;
                        Console.Write(Multiplicacion);
                        break;
                    }
                case 4:
                    {
                        float Division = Num1 / Num2;
                        Console.Write(Division);
                        break;
                    }
                default:
                    {
                        Console.Write("No esta dentro de las opciones");
                        break;
                    }

            }
            

        }
    }
}
