using System;
using System.Collections.Generic;
using System.Text;

namespace HeThongQuanLiSoDienThoai
{
    interface IPhone
    {
        void removePhone(string name);
        void insertPhone(Phone item);
        void updatePhone(Phone item);
        void searchPhone(string name);
        void sort();
    }
}
