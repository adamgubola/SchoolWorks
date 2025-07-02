using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            CsvProcessor processor = new CsvProcessor();
            Workout[] workouts; 

            workouts = processor.AllItems();

            for (int i = 0; i < workouts.Length; i++) { 
            
            Console.WriteLine(workouts[i].ToString());
            
            }

        }
    }
}
