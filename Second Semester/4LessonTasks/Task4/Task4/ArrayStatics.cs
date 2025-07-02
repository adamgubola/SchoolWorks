using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class ArrayStatics
    {
        private int[] numbers;

        public int[] Numbers { get { return numbers; } }

        public ArrayStatics(int[]array)
        {
                this.numbers = array.ToArray();
        }
    public int Total()
        {
            int sum = 0;

            foreach (var i in this.numbers) 
            {
            sum += i;
            }

            return sum;
        }
     public bool Contains(int num)
        {
            bool res = false;

            for(int i = 0; i < this.numbers.Length; i++) 
            {
            if(this.numbers[i] == num) res=true;            
            
            }
            return res;
        }

    public bool Sorted()
        {
            bool res = false;

            if (this.numbers.Length > 0)
            {

                for (int i = 0; i < this.numbers.Length - 1; i++)
                {
                    if (this.numbers[i] < this.numbers[i + 1])
                    {
                        res = true;
                    }
                }
            }
            return res;
        }

    public int FirstGreater(int num)
        {
            int temp = -1;

            if (this.numbers.Length > 0)
            {


                for (int i = 0; i < this.numbers.Length && temp==-1; i++)
                {
                    if (num < this.numbers[i])
                    {
                        temp= this.numbers[i];
                    }
                }
            }
            return temp;
        }

        public int CountEvens()
        {
            int count = 0;

            for(int i = 0;i < this.numbers.Length; i++)
            {
                if(this.numbers[i]%2== 0)
                {
                   count++;
                }
            }
            return count;
        }

        public int MaxIndex()
        {
            int index = 0;
            int maxNumber = 0;

            for (int i = 0; i < this.numbers.Length; i++)
            {
                if (maxNumber < this.numbers[i])
                {
                    maxNumber= this.numbers[i]; 
                    index= i;
                }
            }
            return index;
        }

        public void SortMinOrder()
        {
            int temp = 0;
            int[] tempArray = this.numbers.ToArray();

            for (int i = 0; i < this.numbers.Length - 1; i++)
            {

                for (int j = i+1; j < this.numbers.Length; j++)
                {
                    if (tempArray[i] > tempArray[j])
                    {
                        temp = tempArray[i];
                        tempArray[i] = tempArray[j];
                        tempArray[j] = temp;

                    }
                }
            }
            this.numbers = tempArray;
            
        }

        public void SortMinSelect()
        {
            int temp = 0;
            int[] tempArray = this.numbers.ToArray();

            for(int i = 0;i < this.numbers.Length - 1; i++)
            {
                int index= i;

                for (int j = i+1;j < this.numbers.Length; j++)
                {
                    if (tempArray[index]> tempArray[j])
                    {
                        index = j;
                    }

                }
                temp = tempArray[i];
                tempArray[i] = tempArray[index];
                tempArray[index] = temp;

            }
            this.numbers = tempArray;

        }

        public void SortInsertion()
        {
            int temp = 0;
            int[] tempArray = this.numbers.ToArray();

            for(int i = 1; i < this.numbers.Length; i++)
            {
                int j = i-1;
                temp = tempArray[i];

                while (j >= 0 && tempArray[j] > temp) 
                {
                    tempArray[j+1]= tempArray[j];
                    j--;
                
                }
                tempArray[j + 1] = temp;
            
            }
            this.numbers = tempArray;

        }


    }
}
