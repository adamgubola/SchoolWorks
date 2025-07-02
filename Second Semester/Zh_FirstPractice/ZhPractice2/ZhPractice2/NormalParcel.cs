using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhPractice2
{
    public class NormalParcel : Parcel
    {
        static Random random = new Random(10);
        public NormalParcel(int weight, string address) : base(weight, address, (EType)random.Next(0, 3))
        {
         
        }

        public override double CalculatePrice(bool fromLocker)
        {
            double price = 500;

            if (fromLocker) { price -= 250; }

            price += this.Weight;

            return price;
        }
    }
}
