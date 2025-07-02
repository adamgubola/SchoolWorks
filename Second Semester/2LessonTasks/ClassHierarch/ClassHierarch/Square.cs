using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarch
{
    internal class Square : Rectangle
    {
        public override int Height 
        {             
            set { base.Height = value; 
                  base.Width = value;
            }
        }
        public override int Width
        {
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }

        public Square(string color, int width, bool isHoley = false) : base(color, width, width, isHoley)
        {
        }

        public override string ToString()
        {
            string temp= base.ToString();

            temp = temp.Replace("téglalap","négyzet");

            return temp;
        }

        public override bool Equals(object obj)
        {
            return obj is Square square &&
                   base.Equals(obj) &&
                   IsHoley == square.IsHoley &&
                   Color == square.Color &&
                   Height == square.Width &&
                   Width == square.Width;
        }
    }
}
