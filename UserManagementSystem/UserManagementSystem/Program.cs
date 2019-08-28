using System;
using System.Collections.Generic;

namespace UserManagementSystem
{
    class Program
    {
        public static Dictionary<int, User> user = new Dictionary<int, User>();
        static void Main(string[] args)
        {
            BuildMenu menu = new BuildMenu();
            menu.DrawMenu();
        }
    }
}
