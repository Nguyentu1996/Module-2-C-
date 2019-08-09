using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapW3resource
{
    class BaiTap15
    {
        public static void Main()
        {
            string str = "w3resource";
            Console.WriteLine("nhap vi tri can xoa ");
           var inPut = int.Parse(Console.ReadLine());
            Console.WriteLine(str.Remove(inPut,1));
        }
    }   
}
