using System;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar los números impares entre el 0 y el 100.
            string text = "";

            for (int i=0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    text = text + $", {i}";
                }
            }

            Console.Write("los numeros impares de cero a cien son: "+text);
        }
    }
}
