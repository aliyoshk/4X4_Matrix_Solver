using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixSolution
{
    class MatrixDeterminant
    {
        double d = 0;
        public void Display()
        {
            Console.WriteLine("\t\t\t\tMatrix 4X4 Determinant Finder");
            double[,] mat = new double[10,10];
            int i, j;
            Console.WriteLine("enter the elements");
            for (i=0;i<4;i++)
            {
                for (j=0;j<4;j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nThe Matrix Structure is:");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThe Matrix Determinant is "+Determinant(4, mat));
            Console.ReadKey();
        }

        public double Determinant(int n, double[,] mat)
        {
            int c, subi, i, j, subj;
            double[,] submat = new double[10,10];
            if (n == 2)
            {
                return ((mat[0,0] * mat[1,1]) - (mat[1,0] * mat[0,1]));
            }
            else
            {
                for (c = 0; c<4; c++)
                {
                    subi = 0;
                    for (i = 1; i<4; i++)
                    {
                        subj = 0;
                        for (j = 0; j<4; j++)
                        {
                            if (j == c)
                            {
                                continue;
                            }
                            submat[subi,subj] = mat[i,j];
                            subj++;
                        }
                        subi++;
                    }
                    d = d + (Math.Pow(-1 ,c) * mat[0,c] * Determinant(n - 1 , submat));
                }
            }
            return d;
        }

    }
}
