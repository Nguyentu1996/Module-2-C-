using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric
{
    class Show
    {   
        public  int option = -1;
        public ServiceRectangle service = new ServiceRectangle();
        public  void DrawMenu()
        {
            while (option!=3)
            {
                Console.WriteLine("------Menu------");
                Console.WriteLine("1 : add ");
                Console.WriteLine("2 : view");
                Console.WriteLine("3 : out");
                var choice = int.Parse(Console.ReadLine());
                if(choice <=3 && choice > 0)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Ban hay nhap ");
                            AddMyList();
                            break;
                        case 2:
                            Console.WriteLine("------danh sach ------");
                            Display();
                            break;
                        case 3:
                            option = 3;
                            break;
                    }
                    
                }
            }
        }
        public  void Display()
        {
            foreach (var list in service.ShowList())
            {
                Console.WriteLine("\tChieu dai\tChieu Rong\tDien Tich");
                Console.WriteLine("\t"+list.Width+"\t\t"+ list.Heigth+"\t\t"+list.tinhDienTich());
            }
        }
        public  void AddMyList()
        {
            Console.WriteLine("so luong add ");
            var input = int.Parse(Console.ReadLine());
            for (int i = 0;i < input; i ++) {
                Console.WriteLine("hinh thu "+(i + 1));
                Console.WriteLine("nhap Chieu Dai");
                var chieuDai = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap Chieu Rong");
                var chieuRong = int.Parse(Console.ReadLine());
                var iTem = new Rectangle()
                {
                    Width = chieuRong,
                    Heigth = chieuDai,
                };
                service.AddItem(iTem);
            }

        }
    }
}
