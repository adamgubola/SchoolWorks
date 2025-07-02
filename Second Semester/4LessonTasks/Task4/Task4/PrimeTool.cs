using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class PrimeTool
    {
        private int number;

        public PrimeTool(int number)
        {
            this.number = number;
        }

        public bool IsPrime()
        {
            if (this.number < 0) return false;

            if(this.number == 0 || this.number == 1) return false;

            if(this.number > 1)
            {
                bool isPrime=true;

                for(int i = 2; i<= Math.Sqrt(this.number); i++){

                    if (this.number % i == 0) {
                        isPrime=false;
                    }
                }
                return isPrime;
            }

            return false;
        }
    }
}
