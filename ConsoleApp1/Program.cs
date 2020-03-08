using System;

namespace Matice20
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int m = 4, n = 5; 
            int[,] a = new int[m, n];
            int[,] a0 = new int[m, n];
            int[,] a1 = new int[m, n];
            int[,] a2 = new int[m, n];


            for (int i = 0; i < a.GetLength(0); i++) {
                for (int j = 0; j < a.GetLength(1); j++) { 
                    a[i, j] = random.Next(10);
                    a0[i, j] = a[i, j];
                    a1[i, j] = a[i, j];
                    a2[i, j] = a[i, j];
                }
            }
            

            VypisMatici(a);

            
            Console.WriteLine("Šachovnice: ");
            for (int i = 0; i < a0.GetLength(0); i++)
            {
                for (int j = 0; j < a0.GetLength(1); j++)
                {
                    if (((j % 2 == 0) && (i % 2 == 0) && (a0[i, j] % 2 == 0)) || ((j % 2 != 0) && (i % 2 != 0) && (a0[i, j] % 2 == 0)) || ((j % 2 != 0) && (i % 2 == 0) && (a0[i, j] % 2 != 0)) || ((j % 2 == 0) && (i % 2 != 0) && (a0[i, j] % 2 != 0)))
                    {
                        a0[i, j]++;
                    }
                }
            }
            VypisMatici(a0);
            Console.WriteLine("Vypsání v opačném pořadí: ");
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                for (int j = 0; j < a1.GetLength(1); j++)
                {
                    a1[i, a1.GetLength(1) - (j + 1)] = a[i, j];
                }

            }
            VypisMatici(a1);
            Console.WriteLine("Prohození prvků na řádcích: ");
            int temp;
            for (int i = 0; i < a2.GetLength(0); i+=2)
            {
                for (int j = 0; j < a2.GetLength(1); j++)
                {
                    if (a2.GetLength(0) - 1 > i) {
                        temp = a2[i, j];
                        a2[i, j] = a2[i + 1, j];
                        a2[i + 1, j] = temp;
                    }   
                }
            }
            VypisMatici(a2);

            Console.ReadLine();
        }

        static void VypisMatici(int[,] a)
        {
            // Vypsání matice
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write("{0,2}, ", a[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}