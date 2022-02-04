using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleMethod
{
    public class Class1
    {
        public int Method1(int A)
        {
            return A + 7;
        }
        public int Method2(decimal A)
        {
            int B = Convert.ToInt32(A);
            return B + 8;
        }
    }
}
