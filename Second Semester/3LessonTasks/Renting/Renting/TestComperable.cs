using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renting
{
    internal class TestComperable : IComparable
    {

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public TestComperable(int age)
        {
            this.age = age;
        }

        public int CompareTo(object obj)
        {
            if (obj is TestComperable test) 
            {
              if(test.Age > this.Age)
                {
                    return -1;
                }
              else if (test.Age < this.Age)
                {
                    return 1;
                }
                else { return 0; }

            }
            throw new Exception("Nem megfelelő érték");

        }
    }
}
