using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_First
{
    public abstract class Parcel : IDeliverable, IComparable
    {
        public int Weight { get; private set; }

        public string Address { get; private set; }

        public double Price { get; private set; }

        public EType EType { get; private set; }

        public Parcel(int weight, string address, EType eType)
        {
            Weight = weight;
            Address = address;
            EType = eType;
        }

        public Parcel(int weight, string address)
        {
            Weight = weight;
            Address = address;
        }

        public abstract double CalculatePrice(bool fromLocker);
       

        public int CompareTo(object obj)
        {
            if (obj is IDeliverable p)
            {
                if (p.Weight > this.Weight) return -1;

                else if (p.Weight < this.Weight) return 1;

                else { return 0; }

            }

            throw new ArgumentException();
        }

        public override string ToString()
        {
            return $"Címzett: {this.Address} / Típus: {this.EType} / Tömeg: {this.Weight}g";
        }
    }
}
