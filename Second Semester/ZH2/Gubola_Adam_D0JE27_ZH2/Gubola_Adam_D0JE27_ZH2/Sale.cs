using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubola_Adam_D0JE27_ZH2
{
    public class Sale
    {
        public ShoppingItem[] Shopping { get; private set; }

        public Sale(int size)
        {
            this.Shopping = new ShoppingItem[size];
        }

        public bool IsSorted()
        {

            for (int i = 0; i < Shopping.Length - 1; i++)
            {
                if (this.Shopping[i].CompareTo(Shopping[i + 1]) > 0)
                {
                    return false;
                }
                ;
            }
            return true;
        }
        public void SortItems()
        {
            int i = 1;
            int j;
            ShoppingItem shopping;

            while (i < this.Shopping.Length)
            {
                j = i - 1;
                shopping = this.Shopping[i];

                while (j >= 0 && this.Shopping[j].CompareTo(shopping) > 0)
                {
                    this.Shopping[j + 1] = this.Shopping[j];
                    j--;
                }
                this.Shopping[j + 1] = shopping;
                i++;

            }
        }

        public static Sale LoadFromFile(string path)
        {
            string[] inp = File.ReadAllLines(path);

            Sale result = new Sale(inp.Length);

            for (int i = 0; i < inp.Length; i++)
            {
                result.Shopping[i] = ShoppingItem.Parse(inp[i]);

            }
            if (result.IsSorted())

            { return result; }
            else
            {
                result.SortItems();
                return result;

            }
        }

        public int TotalPrice(Predicate<ShoppingItem> p)
        {
            int total = 0;

            for (int i = 0; i < this.Shopping.Length; i++)
            {
                if (p.Invoke(this.Shopping[i]))
                {
                    total += this.Shopping[i].Price;
                }
            }
            return total;
        }

        public ShoppingItem[] FilterCheapItems(int limit)
        {
            ShoppingItem[] item = new ShoppingItem[this.Shopping.Length];
            int counter = 0;

            for (int i = 0; i < this.Shopping.Length; i++)
            {
                if (this.Shopping[i].Price < limit)
                {
                    item[counter] = this.Shopping[i];
                    counter++;
                }
            }
            Array.Resize(ref item, counter);
            return item;
        }

        public bool HasItem(ShoppingItem item)
        {
            if (IsSorted())
            {
                int bal = 0;
                int jobb = this.Shopping.Length - 1;
                int center = (bal + jobb) / 2;

                while (bal <= jobb && this.Shopping[center].CompareTo(item) != 0)
                {
                    if (this.Shopping[center].CompareTo(item) > 0)
                    {
                        jobb = center - 1;
                    }
                    else { bal = center + 1; }

                    center = (bal + jobb) / 2;

                }
                bool temp = bal <= jobb;
                if (temp)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                throw new ArgumentException("A tömb nem rendezett");
            }
        }


    }



}
