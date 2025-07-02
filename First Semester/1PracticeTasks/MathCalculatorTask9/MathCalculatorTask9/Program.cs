using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalculatorTask9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool calculateIsTrue = true;

            while (calculateIsTrue)
            {
                try
                {
                    Console.WriteLine("Add meg az első számot");
                    int firstNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Add meg az második számot");
                    int secondNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Add meg műveletet. pl.: - , + , / , + ");
                    String operat = Console.ReadLine();
                    if (!(operat.Equals("-") || operat.Equals("+") || operat.Equals("/") || operat.Equals("*"))) 
                    {
                        throw new Exception("Nem megfelelő operátort adtál meg!");
                    }

                    double result;

                    if (operat == "+")
                    {
                        result = firstNumber + secondNumber;
                        Console.WriteLine("Az eredmény: " + result);
                        calculateIsTrue = false;

                    }
                    else if (operat == "-")
                    {
                        result = firstNumber - secondNumber;
                        Console.WriteLine("Az eredmény: " + result);
                        calculateIsTrue = false;
                    }
                    else if (operat == "/")
                    {
                        if (secondNumber == 0)
                        {
                            throw new Exception("Nullával nem lehet osztani!");
                        }
                        result = firstNumber / secondNumber;
                        Console.WriteLine("Az eredmény: " + result);
                        calculateIsTrue = false;
                    }
                    else if (operat == "*")
                    {
                        result = firstNumber * secondNumber;
                        Console.WriteLine("Az eredmény: " + result);
                        calculateIsTrue = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
