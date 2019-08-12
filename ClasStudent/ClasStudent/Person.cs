using System;
using System.Collections.Generic;
using System.Text;

namespace ClasStudent
{
    class Person
    {
        protected int age;
        public void greet()
        {
            Console.WriteLine("hello");

        }
        public void setAge(int age)
        {
            this.age = age;
        }
    }
}
