using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric
{
    class Rectangle : Shape
    {
       public Rectangle()
        {

        }
        public Rectangle(double width, double height) : base(width, height)
        {

        }
        public override double tinhDienTich()
        {
            return Width * Heigth;
        }
        
    }
}
