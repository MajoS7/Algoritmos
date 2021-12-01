using System;

namespace Serie
{
    class Program
    {
        static void Main(string[] args)
        {
            //​Realizar la siguiente serie:
            // 11 12 13 14 15 21 22 23 24 25 31 32 33 34 35
            Console.Write("Ingresé número:");
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 10;
            for (int i=1; i<=number; i++)
            {
                counter = counter + 1;
                Console.WriteLine($"{counter}");

                if (counter % 5 == 0)
                {
                    counter = counter + 5;
                }
                
            }
            
        }
    }
}
