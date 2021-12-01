using System;

namespace DiaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dado un número entre 1 y 7 escriba su correspondiente día de la semana así:

                ➢	1 - Lunes        2 - Martes
                ➢	3 - Miércoles    4 - Jueves
                ➢	5 - Viernes      6 - Sábado
                ➢	7 - Domingo*/
            

            bool check = false;
            int number = 0;

            while (check != true)
            {
                try
                {
                    Console.Write("Digite un numero entre 1 y 6: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number >= 1 && number <= 6)
                    {
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("El numero debe ser un entero entre 1 y 6");
                    }

                }
                catch
                {
                    Console.WriteLine("El numero debe ser un entero entre 1 y 6");
                }


            }

            switch (number)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }

        }
    }
}
