using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixSolution
{
    class MatrixMultiplication
    {
        public int multiplication()
        {
            int i, j;
            int m, n, p, q;
            int[,] a = new int[4, 4];
            Console.WriteLine("\t\t\t\tMatrix Multiplication Calculator");

            Console.WriteLine("Enter the row and column of A Matrix");
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the row and column of B Matrix");
            p = int.Parse(Console.ReadLine());
            q = int.Parse(Console.ReadLine());

            if (n != q)
            {
                Console.WriteLine("These Matrices Cannot be Multiplied");
                return 0;
            }

            else
            {
                Console.WriteLine("Enter Elements of the A matrix");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Matrix A structure is:");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }


                int[,] b = new int[4, 4];
                Console.WriteLine("Enter Elements of the B matrix");
                for (i = 0; i < p; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        b[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Matrix B structure is:");
                for (i = 0; i < p; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nProducts of A X B:");
                int[,] c = new int[4, 4];
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < q; j++)
                    {


                        c[i, j] = 0;
                        for (int k = 0; k < p; k++)
                        {
                            c[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < q; j++)
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
