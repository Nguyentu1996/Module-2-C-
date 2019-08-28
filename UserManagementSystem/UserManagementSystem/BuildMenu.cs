using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementSystem
{
    class BuildMenu
    {
        public static int  id = 0;
        public Dictionary<int, User> userDic = new Dictionary<int, User>();
        
        public void Show()
        {
            foreach(KeyValuePair<int,User> item in userDic)
            {
                
                item.Value.Display();
            }
        }
        public void Add()
        {
            var user = new User();
            user.ID = id;
            Console.WriteLine("Add Name");
            user.Name = Console.ReadLine();
            Console.WriteLine("Add Password");
            user.PassWord = Console.ReadLine();
            Console.WriteLine("add phone Number yes/no");
            var select = Console.ReadLine();
            if (select == "yes")
            {
                Console.WriteLine("INPUT your phone number");
                var phone = int.Parse(Console.ReadLine());
                user.PhoneList.Add(phone);
            }
            
            userDic.Add(user.ID, user);

            DrawMenu();
        }
        public void DrawMenu()
        {
            int choice = -1;
            while (choice != -1)
                Console.WriteLine("Menu");
            Console.WriteLine("1 :ADD User");
            Console.WriteLine("2 : Check User");
            Console.WriteLine("3 : Display All");
            Console.WriteLine("4 : out");
            Console.WriteLine("Options : ");
            var option = int.TryParse(Console.ReadLine(), out int result);
            if (result > 0 && result < 4)
            {
                switch (result)  
                {
                    case 1:
                        id = id + 1;
                        Add();
                        break;
                    case 2:
                        break;
                    case 3:
                        Show();
                        break;
                    case 4:
                        choice = -1;
                        break;
                    default:
                        Environment.Exit(Environment.ExitCode);
                        break;
                }


            }
        }
    }
}
