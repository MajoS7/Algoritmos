using System;

namespace PromedioNotas
{
    class Program
    {
        //Realizar un algoritmo que dado un numero de notas, me permita calcular el promedio y
        //determinar si un alumno tiene una nota superior a 3.5 aprueba.
        static void Main()
        {
    
            bool check = false;
            int numberNotes = 0;
            
            while (check != true)
            {
                try
                {
                    Console.Write("Digite la cantidad de notas: ");
                    numberNotes = Convert.ToInt32(Console.ReadLine());
                    if (numberNotes > 0)
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
            double average = 0;
            Console.WriteLine("Si va colocar decimales recuerde colocarlos con coma");

            for (int i=1; i<=numberNotes; i++)
            {
                Console.Write($"Digite su Nota {i}: ");
                double notes = Convert.ToDouble(Console.ReadLine());
                average = average + notes;
            }

            average = average / numberNotes;

            if (average >= 3.5)
            {
                Console.WriteLine($"Promedio: {average}\nResultado: Aprobo");
            }
            else
            {
                Console.WriteLine($"Promedio: {average}\nResultado: No Aprobo");

            }

        }


        
    }
}
