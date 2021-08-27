using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_Lab
{
    static class ExtensionMethod
    {
        public static int Add(this int a,int b)
        {
            return a + b;
        }
    }
}
