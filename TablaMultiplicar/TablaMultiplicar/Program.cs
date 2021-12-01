using System;

namespace TablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que muestre las tablas de multiplicar del 1 al nueve hasta n.


            Console.Write("Digite n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string text = "";
            int mul = 0;

            for (int j=1; j<=n; j++)
            {
                text = text + $"\tTabla del {j} \n";
                for (int i = 0; i <= 9; i++)
                {
                    mul = j * i;
                    text = text +$"{j}*{i} = {mul}\n";

                }
                text = text + "\n";
            }

            
            Console.WriteLine(text);
        }
    }
}
