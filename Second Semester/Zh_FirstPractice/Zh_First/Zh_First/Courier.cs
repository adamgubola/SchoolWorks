using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_First
{
    public class Courier
    {
        IDeliverable[] deliverables;
        int counter;

        public int AllWeight { get; private set; }

        public Courier(int lenghth)
        {
            this.deliverables = new IDeliverable[lenghth];
            this.counter = 0;

        }

        public void PickUpItem(IDeliverable item)
        {

            if (this.counter < this.deliverables.Length)
            {
                this.deliverables[counter] = item;
                this.AllWeight += item.Weight;

                counter++;
            }
            else
            {
                throw new DeliveryException("A futár nem tud több csomagot felvenni");
            }
        }

        public IDeliverable[] FragilesSorted()
        {
            IDeliverable[] sortedFragile = new IDeliverable[this.deliverables.Length];
            int temp = 0;

            for (int i = 0; i < this.deliverables.Length; i++)
            {
                if (this.deliverables[i] is FragileParcel f)
                {
                    sortedFragile[temp] = f;
                    temp++;
                }

            }
            Array.Resize(ref sortedFragile, temp);
            Array.Sort(sortedFragile);

            return sortedFragile;
        }

    }
}
