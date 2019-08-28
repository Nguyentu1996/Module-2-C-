using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementSystem
{
    public class User : IUserMethod, IUserPro
    {
        private int id;
        private string userName;
        private string password;
        public List<int?> PhoneList = new List<int?>();
        public int ID { get {
                return id;
            } set => id = value; }
        public string Name { get { return userName; } set => userName = value; }
        public string PassWord { get { return password; } set => password = value; }

        public void Display()
        {
            if (PhoneList == null || PhoneList.Count>0)
                Console.WriteLine("Name : {0} ,PassWord: {1} , Phone Number : {2} ID : {3}", Name, PassWord, string.Join(",", PhoneList), ID);
            else Console.WriteLine("Name : {0} ,PassWord: {1} , ID : {2} ", Name, PassWord,ID);
        }

    }
}
