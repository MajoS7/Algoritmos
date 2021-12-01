using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que me calcule la media aritmetica de un conjunto de números.

            bool check = false;
            int quantityNumber = 0;

            while (check != true)
            {
                try
                {
                    Console.Write("Digite la cantidad de numeros: ");
                    quantityNumber = Convert.ToInt32(Console.ReadLine());
                    if (quantityNumber > 0)
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

            
            double number = 0;
            double sum = 0;
            string text = "";

            for (int i = 0; i < quantityNumber; i++)
            {
                Console.Write("Digite el numero: ");
                number = Convert.ToDouble(Console.ReadLine());
                sum = sum + number;
                text = text + $"+ {number}";
            }

            double arithmeticMean = sum / quantityNumber;

            Console.Write($"AM = ({text})/{quantityNumber} = {arithmeticMean}");





        }
    }
}
