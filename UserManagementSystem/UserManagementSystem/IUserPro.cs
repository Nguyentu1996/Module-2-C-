using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementSystem
{
    interface IUserPro
    {
        int ID { get; set; }
        string Name { get; set; }
        string PassWord { get; set; }
    }
}
