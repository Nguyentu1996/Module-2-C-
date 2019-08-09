using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapW3resource
{
    class Btap8
    {
       public static void Main()
        {
            Console.WriteLine("enter the number");
            var number = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                int outPut = number * i;
                Console.WriteLine("{0} x {1} ={2}", number, i, outPut);
            }
        }
    }
}
