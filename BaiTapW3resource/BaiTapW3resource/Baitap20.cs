using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapW3resource
{
    class Baitap20
    {
        public static void Main()
        {
            Console.WriteLine(check(1, 2));
            Console.WriteLine(check(3, 2));
        }
        public static int check(int a,int b)
        {
            if (a > b)
            {
                return (a - b) * 2;
            }
            else return b-a;
        }
    }
}
