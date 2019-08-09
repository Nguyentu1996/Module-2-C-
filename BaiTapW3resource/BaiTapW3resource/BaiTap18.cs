using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapW3resource
{
    class BaiTap18
    {
        public static void Main()
        {
            Console.WriteLine(sum(1, 2));
            Console.WriteLine(sum(2, 2));
        }
        public static int sum(int a , int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
    }
}
