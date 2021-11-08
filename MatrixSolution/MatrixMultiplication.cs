using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MatrixSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tWelcome to Matrix Problem Solver");
            Console.WriteLine("Choose any of the Operation\n1: For Multiplying Matrix\n2: " +
                "For Finding Matrix Determinant\n3: For Finding Matrix Dot Program");
            int choice = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                MatrixMultiplication mul = new MatrixMultiplication();
                mul.multiplication();
            }
            else if (choice == 2)
            {
                MatrixDeterminant mat = new MatrixDeterminant();
                mat.Display();
            }
            else if (choice == 3)
            {
                DotProduct dot = new DotProduct();
                dot.Dot();
            }
            else
            {
                Console.WriteLine("No Such Choice");
            }
        }
    }
}
