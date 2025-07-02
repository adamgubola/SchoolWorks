using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class BankService
    {
        private  Owner owner;

        public  Owner Owner
        {
            get { return owner; }
            private set { owner = value; }
        }

        protected BankService(Owner owner)
        {
            this.owner = owner; 
        }

        public override string ToString()
        {
            return $"A tulajdonos neve: {Owner.Name}";
        }
    }
}
