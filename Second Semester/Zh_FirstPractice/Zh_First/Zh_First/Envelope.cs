using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_First
{
    public class Envelope : IDeliverable
    {
        public string Description { get; private set; }

        public int Weight { get; private set; }

        public string Address { get; private set; }

        public double Price { get; private set; }

        public Envelope(int weight, string address, string description)
        {
            Weight = weight;
            Address = address;
            Description = description;
        }

        public double CalculatePrice(bool fromLocker)
        {
            if (Weight > 0 && Weight < 50) {Price = 200; }

            else if (Weight > 50 && Weight < 500) {  Price = 400; }

            else if (Weight > 500 && Weight < 2000) { Price = 1000; }

            else if (Weight>2000) { throw new OverweightException(); }

            return Price;
        }

        public override string ToString()
        {
            return $"Címzett: {this.Address} / Leírás: {this.Description} / Tömeg: {this.Weight}g";
        }
    }
}
