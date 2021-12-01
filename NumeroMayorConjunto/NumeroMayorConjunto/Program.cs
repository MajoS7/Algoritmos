using System;

namespace NumeroMayorConjunto
{
    class Program
    {
        static void Main()
        {
            //Realizar un algoritmo que me permita imprimir el numero mayor de un conjunto de números ingresados.
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

            double[] numbersSet = new double[quantityNumber];
            double number = 0;

            for (int i = 0; i < quantityNumber; i++)
            {
                Console.Write($"Digite el numero: ");
                number = Convert.ToDouble(Console.ReadLine());
                numbersSet[i] = number;
            }

            for (int i = 0; i < numbersSet.Length; i++)
            {
                for (int currentIndex = 0; currentIndex < numbersSet.Length - 1; currentIndex++)
                {
                    int indexNextItem = currentIndex + 1;

                    if (numbersSet[currentIndex] < numbersSet[indexNextItem]) {

                        double temporaryNumber = numbersSet[currentIndex];
                        numbersSet[currentIndex] = numbersSet[indexNextItem];
                        numbersSet[indexNextItem] = temporaryNumber;

                    }
                }
            }

            Console.Write("\tLista \n" + String.Join(", ", numbersSet)+$"\nEl numero mayor es {numbersSet[0]}");

            
        }
    }
}
