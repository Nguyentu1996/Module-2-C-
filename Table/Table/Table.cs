using System;
using System.Collections.Generic;
using System.Text;

namespace Table
{
    class Table
    {
        private double width, height;
        public Table()
        {

        }
        public Table(double width,double height)
        {
            this.width = width;
            this.height = height;
        }
        public double Width
        { 
            set
            {
                width = value;
            }
            get
            {
                return width;
            }
        }
        public double Height
        {
            set
            {
                height = value;

            }
            get
            {
                return height;
            }
        }
        public double Area()
        {
            return height * width;
        }
        public virtual string ToString()
        {
            return "\nheight: "+Height+"\nwidth:  "+Width+"\nArea:  "+Area()  ;
        }
    }
}
