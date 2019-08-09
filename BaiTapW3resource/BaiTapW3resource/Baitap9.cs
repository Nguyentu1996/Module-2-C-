using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapW3resource
{
    class Baitap9
    {
        public static void Main()
        {
            Console.WriteLine("enter first number");
            var first = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            var second = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            var third = int.Parse(Console.ReadLine());
            Console.WriteLine("enter four number");
            var four = int.Parse(Console.ReadLine());
            int average = (first + second + third + four) / 4;
            Console.WriteLine("average of {0},{1},{2},{3} is : {4}", first, second, third, four,average);
        }
    }
}
