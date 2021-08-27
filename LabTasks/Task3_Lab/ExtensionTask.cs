using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Lab
{
   static  class ExtensionTask
    {
        public static string AddExt(this string word,int num)
        {
            if (num % 2 == 0)
            {
                word +="'s";
            }
            return word ;
        }
       
    }
}
