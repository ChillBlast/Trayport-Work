using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars2
{
    public static class Kata6
    {
        public static int Solution(int value)
        {
            int total = 0;
            value -= 1;
            do
            {
                if (value%5==0 || value%3==0)
                {
                    total += value;
                }
                value -= 1;
            } while (value>0);

            return total;
        }
    }
}
