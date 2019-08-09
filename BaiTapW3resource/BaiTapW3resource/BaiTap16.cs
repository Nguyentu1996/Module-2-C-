using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapW3resource
{
    class BaiTap16
    {
        public static void Main()
        {
            Console.WriteLine(swap("w3resource"));
            Console.WriteLine(swap("Phython"));
            Console.WriteLine(swap("x"));
            
        }
        public static string swap(string str)
        {
            return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1,str.Length-2)+str.Substring(0,1): str;
        }
    }
}
