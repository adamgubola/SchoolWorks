using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarch
{
    internal abstract class Shape
    {
		private bool isHoley;
        private string color;

        public bool IsHoley
		{
			get { return isHoley; }
			private set { isHoley = value; }
		}
		public string Color
		{
			get { return color; }
			set { color = value; }
		}
		public Shape(string color, bool isHoley = false)
        {
            this.isHoley = isHoley;
			this.color = color;
        }
		public void MakeHoley()
		{
			this.isHoley = true;
		}

		public abstract int Premiter();
		public abstract int Area();

		public override string ToString() 
		{
			return $"Szín: {Color}, lyukas: {(IsHoley? "Igen":"Nem")}, kerülete: {this.Premiter()}, " +
					$"területe: {this.Area()}";
		}

        public override bool Equals(object obj)
        {
            return obj is Shape shape &&
                   IsHoley == shape.IsHoley &&
                   Color == shape.Color;
        }
    }
}
