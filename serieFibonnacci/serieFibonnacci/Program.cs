using System;

namespace serieFibonnacci_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que dado un numero me permita calcular la serie de fibonnacci.

            bool check = false;
            int number = 0;
            while (check != true)
            {
                try
                {
                    Console.Write("Digite un numero: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number > 0)
                    {
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Solo se permiten numeros positivos enteros.");
                    }

                }
                catch
                {
                    Console.WriteLine("Solo se permiten numeros positivos enteros.");

                }
            }


            int previous = 0;
            int result = 1;
            int copy = 0;
            string text=$"{previous}, {result}";
            
            for (int i =3; i<=number; i++)
            {
                copy = result;
                result = previous + result;
                previous = copy;
                text = text+$", {result}";
            }
            Console.WriteLine(text);


        }
    }
}
