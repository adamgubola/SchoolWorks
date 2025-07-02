using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarch
{
    internal class Rectangle : Shape
    {
        private int height;
        private int width;

        public virtual int Height
        {
            get { return height; }
            set { height = value; }
        }
        public virtual int Width
        {
            get { return width; }
            set { width = value; }
        }

        public Rectangle(string color, int height, int width, bool isHoley = false) : base(color, isHoley)
        {
            this.height = height;
            this.width = width; 
        }

        public override int Area()
        {
            int area= this.Height*this.Width;

            return area;
        }

        public override int Premiter()
        {
            int premiter= 2*(this.Height + this.Width);

            return premiter;
        }

        public override string ToString()
        {
            string temp = "Típus: téglalap, ";

            temp += base.ToString();

            return temp;
        }

        public override bool Equals(object obj)
        {
            return obj is Rectangle rectangle &&
                   IsHoley == rectangle.IsHoley &&
                   Color == rectangle.Color &&
                   Height == rectangle.Height &&
                   Width == rectangle.Width;
        }
    }
}
