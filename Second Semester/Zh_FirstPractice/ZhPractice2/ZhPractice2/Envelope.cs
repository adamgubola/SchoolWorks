using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhPractice2
{
    public class Envelope : IDeliverable
    {
        public int Weight { get; private set; }

        public string Address { get; private set; }

        public string Description { get; private set; }

        public Envelope(int weight, string address, string description)
        {
            Weight = weight;
            Address = address;
            Description = description;
        }


        public double CalculatePrice(bool fromLocker)
        {
            if (Weight < 50) { return 200; }
            else if (Weight > 50 && Weight < 500) { return 400; }
            else if (Weight > 500 && Weight < 2000) { return 1000; }
            else { throw new OverweightException(); }
        }

        public override string? ToString()
        {
            return $"Címzett: {this.Address} / Leírás: {this.Description} / Tömeg: {this.Weight}g";
        }
    }
}
