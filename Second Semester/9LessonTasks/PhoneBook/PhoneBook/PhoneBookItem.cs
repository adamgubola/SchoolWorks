using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneBookItem :IComparable 
    {
        public string Name { get; private set; }

        public int PhoneNumber { get; private set; }

        public PhoneBookItem(string name, int phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }


        public int CompareTo(object? obj)
        {
            if(obj == null) throw new ArgumentNullException(nameof(obj));

            if (obj is string) 
            {
                return this.Name.CompareTo(obj);
            }
            if (obj is PhoneBookItem phoneBookItem)
            {
                return this.Name.CompareTo((phoneBookItem.Name));
            }
            else
            {
                throw new ArgumentException();
            }

        }

        public override bool Equals(object? obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));

           
            if (obj is PhoneBookItem phoneBookItem)
            {
               if(this.Name.Equals(phoneBookItem.Name) && this.PhoneNumber.Equals(phoneBookItem.PhoneNumber))
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
                throw new ArgumentException();
            }
        }
    }
}
