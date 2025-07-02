using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubola_Adam_D0JE27_ZH2
{
    public class ShoppingItem : IComparable
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                { name = value; }
                else
                {
                    throw new InvalidDataProvidedException("A mező nem lehet üres");
                }
            }
        }


        private int weight;

        public int Weight
        {
            get { return weight; }
            private set
            {

                if (value >= 0)
                {
                    weight = value;
                }
                else { throw new InvalidDataProvidedException("Az ár nem lehet negatív."); }
            }
        }

        private int price;

        public int Price
        {
            get { return price; }
            private set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else { throw new InvalidDataProvidedException("Az ár nem lehet negatív."); }
            }

        }
        private ECategory category;

        public ECategory Category
        {
            get { return category; }
            set
            {
                category = value;
            }
        }

        public ShoppingItem(string name, int weight, int price, ECategory myProperty)
        {
            Name = name;
            Weight = weight;
            Price = price;
            Category = myProperty;
        }

        public ShoppingItem(string name, int weight, int price) : this(name, weight, price, ECategory.Other)
        {
        }

        public int CompareTo(object? obj)
        {
            if (obj is ShoppingItem item)
            {
                return this.Name.CompareTo(item.Name);
            }
            else
            {
                throw new ArgumentException("Nem összehasonlíthatóak");
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj is ShoppingItem item)
            {
                if (item.Name == this.Name &&
                    item.Weight == this.Weight &&
                    item.Price == this.Price &&
                    item.Category == this.Category)
                {
                    return true;
                }

            }
            return false;
        }

        public override string? ToString()
        {
            return $"{this.Name} ({this.Weight} g, {this.Category}) : {this.Price} Ft";
        }

        public static ShoppingItem Parse(string input)
        {
            string[] temp = input.Split(';');

            ShoppingItem shoppingItem = new ShoppingItem(

                temp[0],
                int.Parse(temp[2]),
                int.Parse(temp[3]),
                (ECategory)Enum.Parse(typeof(ECategory), temp[1])
                );
            return shoppingItem ;
        }

        }

    }
