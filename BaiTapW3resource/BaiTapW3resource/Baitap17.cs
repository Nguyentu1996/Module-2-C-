using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapW3resource
{
    class Baitap17
    {
        public static void Main()
        {
            Console.WriteLine("Nhap mot chuoi");
            string str;
            str = Console.ReadLine();
            if (str.Length >=  1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }
        }
    }
}
