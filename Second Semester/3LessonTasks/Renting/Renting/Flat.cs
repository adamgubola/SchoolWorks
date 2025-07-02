using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Renting
{
    internal abstract class Flat :IRealEstate
    {
		private int area;
		private int roomsCount;
		private int inhabitantsCount;
		private int unitPrice;

		public int UnitPrice
		{
			get { return unitPrice; }
			protected set { unitPrice = value; }
		}

		public int InhabitantsCount
		{
			get { return inhabitantsCount; }
			protected set { inhabitantsCount = value; }
		}

		public  int RoomsCount
		{
			get { return roomsCount; }
			protected set { roomsCount = value; }
		}

		public  int Area
		{
			get { return area; }
			protected set { area = value; }
		}

        protected Flat(int unitPrice, int inhabitantsCount, int roomsCount, int area)
        {
            this.UnitPrice = unitPrice;
            this.InhabitantsCount = inhabitantsCount;
            this.RoomsCount = roomsCount;
            this.Area = area;
        }
		public abstract bool MoveIn(int newInhabitants);

        public override string ToString()
        {
			return $"Alapterület: {this.Area}, Szobaszám: {this.RoomsCount}, Lakók száma: {this.InhabitantsCount}, " +
				$"Négyzetméteár: {this.UnitPrice}";
        }

        public int TotalValue()
        {
            return this.UnitPrice * this.Area;
        }
    }
}
