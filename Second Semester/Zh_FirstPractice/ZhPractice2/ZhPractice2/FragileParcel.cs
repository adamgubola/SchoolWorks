using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhPractice2
{
    public class FragileParcel : Parcel
    {


        public FragileParcel(int weight, string address, EType eType) : base(weight, address, eType)
        {
            if (eType == EType.Arbitrary) { throw new IncorrectOrientationException(this); }
        }

        public override double CalculatePrice(bool fromLocker)
        {
            double price = 1000;

            if (fromLocker) { throw new DeliveryException("A csomag nem adható fel automatából"); }

            else 
            { 
                price += this.Weight * 2; 
            }

            return price;
        }
    }
}
