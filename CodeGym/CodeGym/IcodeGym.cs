using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGym
{
    interface IcodeGym
    {
        void add(NhanVien request);
        void update(int index,NhanVien request);
        void delete();
        void getID();
        List<NhanVien> Gets();
    }
}
