using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*El promedio de prácticas de un curso se calcula con base en cuatro notas calificadas de las cuales 
            se elimina la nota menor y se promedian las tres notas más altas.*/

            Console.Write("Digite la nota 1: ");            
            double noteOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite la nota 2: ");
            double noteTwo = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite la nota 3: ");
            double noteThree = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite la nota 4: ");
            double noteFour = Convert.ToDouble(Console.ReadLine());
            double average = 0;

            if (noteOne<noteTwo && noteOne<noteThree && noteOne < noteFour)
            {
                average = (noteTwo + noteThree + noteFour) / 3;
            }

            else if (noteTwo < noteOne && noteTwo < noteThree && noteTwo < noteFour)
            {
                average = (noteOne + noteThree + noteFour) / 3;
            }
            else if (noteThree < noteTwo && noteThree < noteOne && noteThree < noteFour)
            {
                average = (noteTwo + noteOne + noteFour) / 3;
            }
            else
            {
                average = (noteTwo + noteOne + noteThree) / 3;
            }

            Console.WriteLine(average);
        }
    }
}
