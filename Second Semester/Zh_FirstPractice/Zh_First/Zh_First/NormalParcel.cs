using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_First
{
    public class NormalParcel : Parcel
    {
        static Random R = new Random(10);

      
        public NormalParcel(int weight, string address) : base(weight, address, (EType)R.Next(0,3))
        {            

        }

        public override double CalculatePrice(bool fromLocker)
        {
               
                return 500 + this.Weight * 1 - (fromLocker? 250 :0);
            
        }
    }
}
