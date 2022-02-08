using System;
using System.Collections.Generic;
using System.Text;

namespace VoidMethod
{
    class Class1
    {

        public void VoidMethod(int A)
        {
            int Operation = A / 2;
            Console.WriteLine("your number divided by 2 is " + Operation);
        }
        public string MethodOutput(string A, out int B)
        {
            B = A.Length;
            string phrase = "The number of letters in your name is " + B;
            return phrase;
        }
        public int MethodOutput(int C)
        {
            int Orange = C * 5;
            return Orange;
        }
        public static int Method(int B)
        {
            int final = B + 5;
            return final;
        }
     }
}
