using System;
using System.Collections.Generic;
using System.Text;

namespace ClasStudent
{
    class Demo
    {
        public static void Main()
        {
            Person person = new Person();
            person.greet();
            Students students = new Students();
            students.goToClasses();
            students.greet();
            students.setAge(10);
            students.ShowEge();

            Teacher teacher = new Teacher();
            teacher.Explain();
            teacher.setAge(30);
            teacher.greet();
            
        }
    }
}
