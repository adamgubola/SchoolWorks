using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Stack
    {
        private char[] chars;

        public Stack (int num) 
        { 
            this.chars = new char[num];
        
        }

        private int pieces;

        public bool Push(char newItem)
        {
            if (pieces < this.chars.Length) 
            {
                if (pieces == 0)
                {
                    this.chars[pieces] = newItem;
                    pieces++;
                    return true;
                }
                else if (pieces > 0 && pieces < this.chars.Length)
                {
                    int temp = pieces;

                    for (int i = pieces; i < 0; i--)
                    {
                        this.chars[i] = this.chars[i-1];
                        temp--;
                    }
                    this.chars[temp] = newItem;
                    pieces++;
                    return true;
                }
            
            }
            return false;
        }

        public bool Pop(out char item)
        {
            item = Char.MinValue;

            if (pieces <= this.chars.Length)
            {
                if (pieces == 0)
                {
                    return false;
                    item= Char.MinValue;
                }
                else if (pieces > 0 && pieces <= this.chars.Length)
                {
                    item = this.chars[0];
                    
                    for (int i = 0; i < pieces-1; i++)
                    {
                        this.chars[i] = this.chars[i + 1];
                    }
                    this.chars[pieces-1] = char.MinValue;
                    pieces--;
                    return true;
                }

            }
            return false;

        }

    }
}
