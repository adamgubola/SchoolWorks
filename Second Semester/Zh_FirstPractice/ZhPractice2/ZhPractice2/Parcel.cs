using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhPractice2
{
    public abstract class Parcel : IDeliverable , IComparable
    {
        public int Weight { get; private set; }

        public string Address { get; private set; }

        public EType EType { get; private set; }

        public abstract double CalculatePrice(bool fromLocker);

        protected Parcel(int weight, string address, EType eType)
        {
            Weight = weight;
            Address = address;
            EType = eType;
        }

        protected Parcel(int weight, string address)
        {
            Weight = weight;
            Address = address;
        }

        public int CompareTo(object? obj)
        {
           if (obj is IDeliverable d)
            {
                if (this.Weight < d.Weight) return -1;

                else if (this.Weight > d.Weight) { return 1; }

                else { return 0; }
            }
            throw new ArgumentNullException(nameof(obj));

        }
        public override string ToString()
        {
            return $"Címzett: {this.Address} / Típus: {this.EType} / Tömeg: {this.Weight}g";
        }
    }
}
