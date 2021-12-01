using System;

namespace ConjuntoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar los números de 1 hasta el número ingresado por teclado.
            Console.Write("Ingresa numero: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string text = "";
            for (int i=1; i<=number; i++)
            {
                text = text + $" {i}";
            }
            Console.Write(text);
        }
    }
}
