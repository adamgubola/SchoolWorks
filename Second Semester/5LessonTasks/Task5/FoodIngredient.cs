using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class FoodIngredient
    {
        public string Name { get; private set; }
        public int Quantity { get; set; }
        public Units Unit { get; private set; }

        public override string ToString()
        {
            return $"Név: {this.Name}, Mennyiség: {this.Quantity}, Egység: {this.Unit}";
        }

        public FoodIngredient(string name, int quantity, Units unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
    }
}
