using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethod
{
    public class Class1
    {
        public int Method1(int A)
        {
            return A + 7;
        }
        public int Method1(decimal A)
        {
            int B = Convert.ToInt32(A);
            return B + 8;
        }
        public int Method1(string A)
        {
            int C = Convert.ToInt32(A);
            return C + 10;
        }
    }
}
