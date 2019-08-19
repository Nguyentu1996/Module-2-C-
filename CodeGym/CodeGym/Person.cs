using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGym
{
    class Person 
    {
        private string name;
        private string age;
        private string id;
        private string gioiTinh;
        private string ngaySinh;
        public Person()
        {

        }
        public Person(string name,string age , string id,string gioiTinh,string ngaySinh)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;

        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
           
        }
        public string Age
        {
            get
            {
                return age;
            }
            set
            { 
                age = value;
            }
        }
        public string ID
        {
            get
            {
                return id;

            }
            set
            {   

                id = value;
            }
        }
        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }
            set
            {
                gioiTinh = value;
            }
        }
        public string NgaySinh
        {
            get
            {
                return ngaySinh;
            }
            set
            {
                ngaySinh = value;
            }
        }
    }
}
