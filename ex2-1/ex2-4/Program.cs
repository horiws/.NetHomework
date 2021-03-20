using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_4
{
    class Program
    {
        static bool toeplitz(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            for (int m = 1; m < row; m++)
            {
                for (int n = 1; n < col; n++)
                {
                    if (matrix[m,n] != matrix[m - 1,n - 1])
                    {
                        Console.WriteLine("This matrix isn't a Toeplitz matrix!");
                        return false;
                    }
                }
            }

            Console.WriteLine("This matrix is a Toeplitz matrix!");
            return true;
        }

        static void Main(string[] args)
        {

            int[,] matrix = new int[,] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };

            toeplitz(matrix);

            Console.Read();

        }
    }
}
