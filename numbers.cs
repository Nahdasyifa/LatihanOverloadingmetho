using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        int totalmin;
        int totalmax;

        public int FindMinimum(int number1, int number2)
        {
            totalmin = number1;
            if (totalmin > number2)
                totalmin = number2;
            return totalmin;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            totalmin = number1;
            if (totalmin > number2)
                totalmin = number2;
            if (totalmin > (int)number3)
                totalmin = (int)number3;
            return totalmin;
        }

        public int FindMaximum(int number1, int number2)
        {
            totalmax = number1;
            if (totalmax > number2)
                totalmax = number2;
            return totalmax;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            totalmax = number1;
            if (totalmax > number2)
                totalmax = number2;
            if (totalmax > (int)number3)
                totalmax = (int)number3;
            return totalmax;
        }
    }
}