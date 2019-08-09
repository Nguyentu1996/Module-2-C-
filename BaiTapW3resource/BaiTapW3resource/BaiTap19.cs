using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapW3resource
{
    class BaiTap19
    {
        public static void Main()
        {
            Console.WriteLine("input first integer");
            var first = int.Parse(Console.ReadLine());
            Console.WriteLine("input second integer");
            var second = int.Parse(Console.ReadLine());
            if(first >= 0 && second >= 0)
            {
                Console.WriteLine("check is false");
            }else if(first<0 && second < 0)
            {
                Console.WriteLine("check is false");

            }else
            {
                Console.WriteLine("check is one is negative and one is positive");
                Console.WriteLine("True");
            }
        }
    }
}
