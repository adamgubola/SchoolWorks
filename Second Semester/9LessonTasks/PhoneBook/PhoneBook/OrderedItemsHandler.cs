using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class OrderedItemsHandler
    {
        public IComparable[] Numbers { get; private set; }

        public OrderedItemsHandler(IComparable[] numbers)
        {
            this.Numbers = new IComparable[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Numbers[i] = numbers[i];
            }
        }

        public bool IsOrdered(bool isAscending = true)
        {
            if (isAscending)
            {
                for (int i = 0; i < this.Numbers.Length - 1; i++)
                {
                    if (this.Numbers[i].CompareTo(this.Numbers[i + 1]) < 0)
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < this.Numbers.Length - 1; i++)
                {
                    if (this.Numbers[i].CompareTo(this.Numbers[i + 1]) > 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void Sort(SortingMethod sortingMethod, bool isAscending = true)
        {
            if (IsOrdered(isAscending))
            {
                return;
            }

            switch (sortingMethod)
            {
                case SortingMethod.Selection:

                    int orderMultiplier = isAscending ? 1 : -1;

                    IComparable temp;
                    for (int i = 0; i < this.Numbers.Length - 1; i++)
                    {
                        int min = i;
                        for (int j = i + 1; j < this.Numbers.Length; j++)
                        {
                            if (this.Numbers[min].CompareTo(this.Numbers[j]) * orderMultiplier > 0)
                            {
                                min = j;
                            }
                        }
                        temp = this.Numbers[i];
                        this.Numbers[i] = this.Numbers[min];
                        this.Numbers[min] = temp;

                    }
                    break;

                case SortingMethod.Bubble:

                    int idx = this.Numbers.Length;
                    orderMultiplier = isAscending ? 1 : -1;

                    while (idx >= 1)
                    {
                        int tempIdx = 0;

                        for (int i = 0; i < this.Numbers.Length - 1; i++)
                        {
                            if (this.Numbers[i].CompareTo(this.Numbers[i + 1]) * orderMultiplier > 0)
                            {
                                temp = this.Numbers[i];
                                this.Numbers[i] = this.Numbers[i + 1];
                                this.Numbers[i + 1] = temp;
                                tempIdx = i;
                            }
                        }
                        idx = tempIdx;

                    }

                    break;

                case SortingMethod.Insertion:

                    orderMultiplier = isAscending ? 1 : -1;

                    for (int i = 1; i < this.Numbers.Length; i++)
                    {
                        int j = i - 1;
                        temp = this.Numbers[i];

                        while (j >= 0 && this.Numbers[j].CompareTo(temp) * orderMultiplier > 0)
                        {
                            this.Numbers[j + 1] = this.Numbers[j];
                            j--;
                        }
                        this.Numbers[j + 1] = temp;
                    }
                    break;
            }
        }

        public bool BinariSearch(IComparable comparable, out int idx)
        {
            idx = -1;

            if (IsOrdered())
            {
                int bal = 0;
                int jobb = this.Numbers.Length - 1;
                int center = (bal + jobb) / 2;

                while (bal <= jobb && this.Numbers[center].CompareTo(comparable) != 0)
                {
                    if (this.Numbers[center].CompareTo(comparable) > 0)
                    {
                        jobb = center - 1;
                    }
                    else { bal = center + 1; }

                    center = (bal + jobb) / 2;

                }
                bool temp = bal <= jobb;
                if (temp)
                {
                    idx = center;
                    return true;
                }
                else { throw new NotOrderedItems(); }
            }
            return false;

        }

        public bool BinariSearchRecursive(IComparable comparable, out int idx)
        {
            if (!IsOrdered())
            {
                throw new NotOrderedItems();
            }

            return BinariSearchRecursive(comparable, 0, this.Numbers.Length - 1, out idx);
        }


        public bool BinariSearchRecursive(IComparable comparable, int bal, int jobb, out int idx)
        {
            if (!IsOrdered())
            {
                throw new NotOrderedItems();
            }

            if (bal > jobb) { idx = -1; return false; }

            int center = (bal + jobb) / 2;

            int temp = this.Numbers[center].CompareTo(comparable);

            if (temp == 0)
            {
                idx = center;
                return true;
            }
            else if (temp > 0)
            {
                return BinariSearchRecursive(comparable, bal, center - 1, out idx);
            }
            else
            {
                return BinariSearchRecursive(comparable, center + 1, jobb, out idx);
            }

        }

        public bool BinariSearchForNextBigger(IComparable comparable, out int idx)
        {
            idx = -1;

            if (!IsOrdered()) { throw new NotOrderedItems(); }


            int bal = 0;
            int jobb = this.Numbers.Length - 1;
            int center = (bal + jobb) / 2;
            int biggerResult = -1;

            while (bal <= jobb && this.Numbers[center].CompareTo(comparable) != 0)
            {

                if (this.Numbers[center].CompareTo(comparable) >= 0)
                {
                    biggerResult = center;
                    jobb = center - 1;
                    center = (bal + jobb) / 2;

                }
                else
                {
                    bal = center + 1; center = (bal + jobb) / 2;
                }

            }

            if (bal <= jobb)
            {
                idx = center;
                return true;
            }
            else if (biggerResult != -1)
            {
                idx = biggerResult;
                return true;
            }

            return false;

        }

       public int CountEqualItems(IComparable comparable)
        {
            int res = 0;

            if (!IsOrdered())
            {
                throw new NotOrderedItems();
            }

            for(int i = 0; i < this.Numbers.Length && this.Numbers[i].CompareTo(comparable)<=0; i++)
            {
                if (this.Numbers[i].CompareTo(comparable) == 0)
                {
                    res++;
                }
            }

            return res;
        }

        public int findFirstEqualBinary(IComparable comparable)
        {
            int res = -1;
            int left = 0;
            int right = this.Numbers.Length - 1;

            if (!IsOrdered())
            {
                throw new NotOrderedItems();
            }

            while(left < right)
            {
                int center = (left - right) / 2;
                int comp = this.Numbers[center].CompareTo(comparable);

                if(comp == 0)
                {
                    res = comp;
                    right = center - 1;
                }
                else if(comp <0)
                {
                    left = center + 1;
                }
                else
                {
                    right = center - 1;
                }


            }

            return res;
        }

        public int FindLastEqualBinary(IComparable comparable)
        {
            int res = -1;
            int left = 0;
            int right = this.Numbers.Length - 1;

            if (!IsOrdered())
            {
                throw new NotOrderedItems();
            }

            while (left < right)
            {
                int center = (left - right) / 2;
                int comp = this.Numbers[center].CompareTo(comparable);

                if (comp == 0)
                {
                    res = comp;
                    right = center +1;
                }
                else if (comp < 0)
                {
                    left = center + 1;
                }
                else
                {
                    right = center - 1;
                }


            }

            return res;
        }

        public int CountEqualItemsBinary(IComparable comparable)
        {
            if (!IsOrdered())
            {
                throw new NotOrderedItems();
            }

            int first = findFirstEqualBinary(comparable);
            if (first == -1)
                return 0;

            int last = FindLastEqualBinary(comparable);

            return last - first + 1;
        }
    }
}