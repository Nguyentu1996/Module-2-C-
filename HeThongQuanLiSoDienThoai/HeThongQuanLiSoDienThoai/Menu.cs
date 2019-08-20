using System;
using System.Collections.Generic;
using System.Text;
using HeThongQuanLiSoDienThoai.Models;

namespace HeThongQuanLiSoDienThoai
{
    class Menu
    {
       public PhoneBook set = new PhoneBook();
        public void Display()
        {
            Console.WriteLine("Name\t\tPhoneNumber");
            if(set.PhoneList!=null && set.PhoneList.Count > 0)
            {
                foreach( Phone PhoneItem in set.PhoneList)
                {
                    Console.WriteLine(PhoneItem.Name + "\t\t" + PhoneItem.Phonee);
                }
                

                
            }
        }
        public void search()
        {
            Console.WriteLine("nhap name muon tim");
            var nameSearch = Console.ReadLine();
            set.searchPhone(nameSearch);
        }
        public void update()
        {
            Console.WriteLine("nhap ten muon cap nhat");
            var nameUpd = Console.ReadLine();
            Console.WriteLine("New name");
            var newName = Console.ReadLine();
            var item = new Phone()
            {
                Name = nameUpd,
                NewPhone=newName
            };
            set.updatePhone(item);
        }
        public void remove()
        {
            Console.WriteLine("nhap ten muon xoa");
            var nameDel = Console.ReadLine();
            set.removePhone(nameDel);
        }
        public void InsertList()
        {
            Console.WriteLine("add name");
            var ten = Console.ReadLine();
            Console.WriteLine("add phone");
            var number = Console.ReadLine();
            var item = new Phone()
            {
                Name = ten,
                Phonee = number
            };
            set.insertPhone(item);
        }
        public void DraMenu()
        {
            
            int choice = -1;
            while (choice != 7)
            {
                
                Console.WriteLine("MeNu");
                Console.WriteLine("1 : remove");
                Console.WriteLine("2 : insert");
                Console.WriteLine("3 : update");
                Console.WriteLine("4 : search");
                Console.WriteLine("5 : sort");
                Console.WriteLine("6 : view");
                Console.WriteLine("7 : quit");
                var input=Console.ReadLine();
                bool check;
                int selected;
                check = int.TryParse(input, out selected);
                if (check== true && selected>0& selected<8)
                {
                    Console.Clear();
                    switch (selected)
                    {
                        case 1:
                            remove();
                            
                            break;
                        case 2:
                            InsertList();
                            break;
                        case 3:
                            update();
                            break;
                        case 4:
                            search();
                            break;
                        case 5:
                            break;
                        case 6:
                            Display();
                            break;
                        case 7:
                            choice = 7;
                            break;
                    }
                }
            }
        }
    }
}
