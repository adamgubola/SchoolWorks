using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_First
{
    public class FragileParcel : Parcel
    {
        public FragileParcel(int weight, string address, EType eType) : base(weight, address, eType)
        {
            if (eType == EType.Arbitrary)
            {
                throw new IncorrectOrientationException(this);
            }
        }

        public override double CalculatePrice(bool fromLocker)
        {
            if (!fromLocker)
            {
                return 1000 + this.Weight * 2;

            }
            else
            {
                throw new DeliveryException("Nem lehet automatából feladni");
            }
        }
    }
}
