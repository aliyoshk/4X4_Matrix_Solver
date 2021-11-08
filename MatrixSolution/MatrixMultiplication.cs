using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixSolution
{
    class MatrixMultiplication
    {
        public int multiplication()
        {
            int i, j, m, n, p, q;
            int[,] a = new int[4, 4];
            Console.WriteLine("\t\t\t\tMatrix Multiplication Calculator");

            Console.WriteLine("Enter the Number of Rows and Column of  A Matrix");
            m = Int32.Parse(Console.ReadLine());
            n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Number of Rows and Column of B Matrix");
            p = Int32.Parse(Console.ReadLine());
            q = Int32.Parse(Console.ReadLine());

            if (n != p)
            {
                Console.WriteLine("This Matrices Cannot be Multiplied");
                return 0;
            }

            else
            {
                Console.WriteLine("Enter Elements of the A matrix");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; n < 4; j++)
                    {
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Matrix A structure is:");
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }


                int[,] b = new int[4, 4];
                Console.WriteLine("Enter Elements of the B matrix");
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        b[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Matrix B structure is:");
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nProducts of A X B:");
                int[,] c = new int[4, 4];
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {


                        c[i, j] = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            c[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.Write(c[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
                return 0;
            }
        }
    }
}
