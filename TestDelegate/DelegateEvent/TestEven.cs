using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateEvent
{
    public delegate void Print();
   public class TestEven
    {
      public event Print Display;
        public void Show()
        {
            Console.WriteLine("tu dep trai vo dich thanh lich nhat vu tru");
        }
        public static void Main()
        {
            TestEven test = new TestEven();
            test.Display += new Print(test.Show);
            test.Display();

        }

    }
}
