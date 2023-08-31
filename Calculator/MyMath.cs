using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class MyMath
    {
        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static bool Intersects(int firstMin, int firstMax, int secondMin, int secondMax)
        {
            if (secondMin > firstMin && secondMin < firstMax)
                return true;

            if (secondMax > firstMin && secondMax < firstMax)
                return true;

            if (firstMin > secondMin && firstMax < secondMax)
                return true;

            return false;
        }
    }
}
