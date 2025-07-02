using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renting
{
    internal class Lodgings : Flat, IRent
    {
		private int bookedMonths;

        protected int BookedMonths
        {
            get { return bookedMonths; }
            set { bookedMonths = value; }
        }


        public Lodgings(int unitPrice, int roomsCount, int area) : base(unitPrice, 0, roomsCount, area)
        {
            BookedMonths = 0;

        }

        public bool IsBooked {get { return bookedMonths != 0; } }
         

        public bool Book(int months)
        {
            if (!IsBooked)
            {
                BookedMonths=months;
                return true;
            } 
            return false;
        }

        public int GetCost(int months)
        {
            return (int)(this.TotalValue() / 240.0 / this.InhabitantsCount);
        }

        public override bool MoveIn(int newInhabitants)
        {
            if (IsBooked) 
            {
                if(this.InhabitantsCount+newInhabitants >= this.RoomsCount*8)
                {
                    if( this.Area / this.InhabitantsCount + newInhabitants >= 2)
                    {
                        this.InhabitantsCount += newInhabitants;
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Foglalt hónapok száma: {BookedMonths}";
        }
    }
}
