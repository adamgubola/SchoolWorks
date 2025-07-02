using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(5);
            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            stack.Push('d');
            stack.Push('f');

            stack.Pop(out char item);
            Console.WriteLine(item);
            stack.Pop(out char item2);
            Console.WriteLine(item2);   
            stack.Pop(out char item3);
            Console.WriteLine(item3);
            stack.Pop(out char item4);
            Console.WriteLine(item4);
            bool res = stack.Pop(out char item5);
            Console.WriteLine(item5);
        }
    }
}
