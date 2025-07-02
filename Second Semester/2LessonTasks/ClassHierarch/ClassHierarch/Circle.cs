using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarch
{
    internal class Circle : Shape
    {
       private int radius;

        public int Radius
        {
            get { return radius; }
            private set { radius = value; }
        }

        public object Radisu { get; private set; }

        public Circle(int radius, string color, bool isHoley = false) : base(color, isHoley)
        {
            Radius = radius;  
        }

        public override int Area()
        {
            
            return (int)Math.Round(Math.Pow(radius, 2) * Math.PI);
        }

        public override int Premiter()
        {
            return (int)Math.Round(2*radius*Math.PI);
        }

        public override bool Equals(object obj)
        {
            return obj is Circle circle &&
                   IsHoley == circle.IsHoley &&
                   Color == circle.Color &&
                   Radius == circle.Radius;
        }

        public override string ToString()
        {
            return base.ToString()+$"\t kerület= {this.radius}";
        }
    }
}
