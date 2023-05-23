using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    internal class Matrix
    {
        public int[,] GenerateMatrix(int n)
        {
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i * j < 3)
                    {
                        matrix[i, j] = i + j;
                    }
                    else
                    {
                        int sum = 0;
                        for (int k = 1; k <= j; k++)
                        {
                            sum += ((-1) * k) * k;
                        }
                        matrix[i, j] = sum;
                    }
                }
            }

            return matrix;
        }
    }
}

