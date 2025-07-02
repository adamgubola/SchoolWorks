using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhPractice2
{
    public class Courier
    {
        IDeliverable [] deliverable;
        public int Counter = 0;

        public int AllWeight { get; private set; }

        public Courier(int inp)
        {
            this.deliverable = new IDeliverable[inp];
            
        }

        public void PickUpItem(IDeliverable item)
        {
            if (Counter < deliverable.Length)
            {
                this.deliverable[Counter] = item;
                AllWeight += item.Weight;
                Counter++;
            }
            else
            {
                throw new DeliveryException();
            }
        }

        public IDeliverable[] FragilesSorted()
        {
            IDeliverable[] temp = new IDeliverable[this.deliverable.Length];
            int counter = 0;

            for (int i = 0; i < this.deliverable.Length; i++) 
            {
                if (this.deliverable[i] is FragileParcel f)
                {
                    temp[counter] = f;
                    counter++;
                }
            
            }

            Array.Resize(ref temp, counter);
            Array.Sort(temp);
            return temp;
        }

    }
}
