using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric
{
    class ServiceRectangle : RectangleService
    {
        List<Rectangle> myList = new List<Rectangle>();
        public void AddItem(Rectangle iTem)
        {
            myList.Add(iTem);
        }
        public List<Rectangle> ShowList()
        {
            return myList;
        }
        
     
    }
}
