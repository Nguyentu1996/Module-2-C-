using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapW3resource
{
    class BaiTap21
    {
        public static void Main()
        {
            int x, y;
            Console.WriteLine("nhap x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap y");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine(x == 20 || y == 20 || x + y == 20);
        }
    }
}
