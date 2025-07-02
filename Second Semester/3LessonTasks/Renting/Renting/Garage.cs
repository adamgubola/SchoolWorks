using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renting 
{
    internal class Garage :IRealEstate, IRent
    {
		private int area;
		private int unitePrice;
		private bool isHeated;
		private int months;
		private bool isOccupied;

		public bool IsOccupied
		{
			get { return isOccupied; }
			protected set { isOccupied = value; }
		}


		public int Months
		{
			get { return months; }
			protected set { months = value; }
		}


		public bool IsHeated
		{
			get { return isHeated; }
			protected set { isHeated = value; }
		}


		public int UnitePrice
		{
			get { return unitePrice; }
			protected set { unitePrice = value; }
		}

		public int Area
		{
			get { return area; }
			protected set { area = value; }
		}

        public bool IsBooked { get { return this.Months > 0 || this.IsOccupied; } }

        public bool Book(int months)
        {
			if (!IsBooked) 
			{ 
				this.months = months;
				return true;
			}
			return false;
        }

        public int GetCost(int months)
        {

			if (this.IsHeated) 
			{
				return (int)(this.Area*this.UnitePrice/120.0*months);
			}
			else
			{
				return (int)(this.Area * this.UnitePrice / 120.0 * 1.5*months);
			}

        }

        public int TotalValue()
        {
            return this.Area* this.UnitePrice;
        }

        public void UpdateOccupied()
		{
			if (this.IsOccupied)
			{
				this.IsOccupied = false;
			}
			this.IsOccupied=true;
		}

        public Garage(bool isHeated, int unitePrice, int area)
        {
            IsHeated = isHeated;
            UnitePrice = unitePrice;
            Area = area;
        }

        public override string ToString()
        {
			return $"Alapterület: {this.Area}, Négyzetméterár: {this.UnitePrice}, " +
				$"Fűtött: {(this.IsHeated? "Igen" : "Nem")}, Lefoglalt hónapok: {this.Months}" +
				$"Foglalt: {(this.IsOccupied? "igen":"nem")}";
        }
    }
}
