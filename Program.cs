using System;

namespace Vícerozměrné_pole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] kinosal = new int[5, 5];
            kinosal[2, 2] = 1;
            for (int sloupec=1;sloupec<4;sloupec++)
            {
                kinosal[sloupec, 3] = 1;
            }
            for (int sloupec=0;sloupec<5;sloupec++)
            {
                kinosal[sloupec, 4] = 1;
            }
            for(int radek=0;radek<kinosal.GetLength(1);radek++)
            {
                for(int sloupec=0;sloupec<kinosal.GetLength(0);sloupec++)
                {
                    Console.Write(kinosal[sloupec, radek]);
                }
                Console.WriteLine();
            }

        }
    }
}
