using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric
{
    abstract  class Shape
    {
        private double width;
        private double height;
        

        public Shape()
        {

        }
        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public double Heigth { get { return height; } set { height = value; } }
        public abstract double tinhDienTich();
    }
}
