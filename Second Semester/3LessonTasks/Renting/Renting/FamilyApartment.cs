using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renting
{
    internal class FamilyApartment :Flat
    {
		private int childrenCount;
        public int ChildrenCount
		{
			get { return childrenCount; }
			set { childrenCount = value; }
		}

        public FamilyApartment(int unitPrice, int roomsCount, int area) : base(unitPrice, 0, roomsCount, area)
        {
            this.ChildrenCount = 0;
        }

        public bool ChildIsBorn()
        {
            if(this.InhabitantsCount-this.ChildrenCount >= 2)
            {
                this.ChildrenCount ++;
                this.InhabitantsCount++;
                return true;
            }
            return false;
        }

        public override bool MoveIn(int newInhabitants)
        {
            if (this.RoomsCount / this.InhabitantsCount <= 2)
            {
                if (this.Area / (((this.InhabitantsCount - this.ChildrenCount) * 10) +
                    (this.ChildrenCount * 5)) >= 0)
                {
                    if ((this.Area - this.InhabitantsCount * 10) - 5 >= 0)
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
            return $"{base.ToString()}, Gyerekek száma: {this.ChildrenCount}";
        }
    }
    }
