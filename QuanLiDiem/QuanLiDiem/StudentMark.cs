using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace QuanLiDiem
{
    class StudentMark :IStudentMark
    {
        public List<Student> studentList = new List<Student>();

        
       public void Insert(Student item)
        {
            studentList.Add(item);
        }
      
     

    }
}
