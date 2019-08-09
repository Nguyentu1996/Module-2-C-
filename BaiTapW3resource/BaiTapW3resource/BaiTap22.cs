using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapW3resource
{
    class BaiTap22
    {
        public static void Main()
        {
            Console.WriteLine("enter the number");
            var number = int.Parse(Console.ReadLine());
           
        }
        public static bool checkNumber(int a)
        {
            return (Math.Abs(a - 100) <= 20 || Math.Abs(a - 200) <= 20) ? true : false;
        }
    }
}
