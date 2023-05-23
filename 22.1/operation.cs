using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp24
{
    internal class operation
    {
        public double SumBeforeFirstNegativeElement(List<double> array)
        {
            double sum = 0;

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] < 0)
                {
                    break;
                }

                sum += array[i];
            }

            return sum;
        }
    }
}


