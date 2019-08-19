using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGym
{
    class Service:IcodeGym
    {
        List<NhanVien> myList = new List<NhanVien>();
        public void add(NhanVien request)
        {
            myList.Add(request);
        }

         public  void  update(int index,NhanVien request)
        {
            if (index > myList.Count) {
                Console.WriteLine("khong chen that bai : index > do dai cua danh sach ");
            }
            else
            {
                myList.Insert(index, request);
                Console.WriteLine("chen thanh cong");
                
               
            }
           
        }

         public void delete()
        {
           myList.Clear();
        }

         public void getID()
        {
            throw new NotImplementedException();
        }

        public  List<NhanVien> Gets()
        {
           
                return myList;
            
        
        }
        public bool IsEmpty()  
        {
            var list = Gets();
            return list != null && list.Count > 0;
             
        }
       
       

       
    }
}
