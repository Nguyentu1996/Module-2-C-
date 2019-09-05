using System;
using System.Collections.Generic;
using System.Text;

namespace BT3
{
    class Forum
    {
       
        List<Pos> postList = new List<Pos>();
       
        public  void CreatePos()
        {
            Pos pos = new Pos();
            Console.WriteLine("Nhap Id :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Title:");
            var title = Console.ReadLine();
            Console.WriteLine("Nhap ConTent");
            var content = Console.ReadLine();
            Console.WriteLine("Nhap Author");
            var author = Console.ReadLine();
            for(int i=0; i<pos.Rates.Length;i++)
            {
                Console.WriteLine("Rate :");
                pos.Rates[i] = int.Parse(Console.ReadLine());
            }


            pos.Id = id;
            pos.Title = title;
            pos.Conten = content;
            pos.Author = author;


           
            postList.Add(pos);
        }
        public static void Main()
        {

        }
    }
}
