using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calc1
{
    public class Calc1
    {
        public static int Calculate(int a, int b, char zn)
        {
            int res = 0;
            switch (zn)
            {
                case '+':
                    res = a + b;
                    break;
                case '-':
                    res = a - b;
                    break;
                case '*':
                    res = a * b;
                    break;
                case '/':
                    if (b == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    res = a / b;
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return res;

        }
    }
}
