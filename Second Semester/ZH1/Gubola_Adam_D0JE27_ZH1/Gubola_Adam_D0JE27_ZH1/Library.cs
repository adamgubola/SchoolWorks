using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubola_Adam_D0JE27_ZH1
{
    public class Library
    {
        public IBookable[] Borrows { get; private set; }

        public Library(int lenght)
        {
            Borrows = new IBookable[lenght];
            ActualBorrowNum = 0;
        }

        public int ActualBorrowNum { get; private set; }

        public void AddBook(IBookable book)
        {
            if (this.ActualBorrowNum < this.Borrows.Length)
            {
                this.Borrows[this.ActualBorrowNum] = book;
                this.ActualBorrowNum++;
            }
            else
            {
                throw new LibraryFullException();
            }
        }

        public IBookable[] OverdueBooks(int currentDay)
        {
            IBookable [] temp= new IBookable[this.Borrows.Length];
            int counter = 0;

            for (int i = 0; i < this.Borrows.Length; i++) 
            {
               
                    if (currentDay > this.Borrows[i].LoanPeriod)
                    {
                        temp[counter]=this.Borrows[i];
                        counter++;
                    }
                
               
            }
            Array.Resize(ref temp, counter);

            return temp;
        }




    }
}
