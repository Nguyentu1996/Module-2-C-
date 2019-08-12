using System;
using System.Collections.Generic;
using System.Text;

namespace ClasStudent
{
    class Students : Person
    {   
        public void ShowEge()
        {
            Console.WriteLine("my age is {0}", age);
        }
        public void goToClasses()
        {
            Console.WriteLine( "i'm going to class");
        }

    }
}
