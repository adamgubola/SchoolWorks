using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportWatch
{
    public class CsvProcessor
    {
        public Workout[] workouts;

        public CsvProcessor()
        {
        }

        public Workout[] AllItems()
        {
            int idx = 0;
            string[] inp = null;

            try
            {
             inp = File.ReadAllLines("input.csv");
             idx = inp.Length-1;

            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("A file nem található)");
            
            }

            workouts = new Workout[idx];

            if (idx > 0)
            {
                int temp = 0;
               
               for (int i = 0; i < idx; i++)
               {
                    try
                    {
                        workouts[i] = Workout.Parse(inp[i + 1]);
                        temp++;

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine($"A sorok adataiban hiba található: {e.Message}");

                    }
                }
                
                workouts = Copy(temp, workouts);

                return workouts;

            }
            else
            {
                Console.WriteLine("A file üres");
                throw new WorkoutException();
            }
        }

        public Workout[] Copy(int size, Workout[] work)
        {
            Workout[] temp = new Workout[size];

            if (this.workouts == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                int counter = 0;

                for (int i = 0; i < this.workouts.Length; i++)
                {
                    {
                        if (this.workouts[i] != null)
                        {
                            temp[counter] = this.workouts[i];
                            counter++;
                        }
                    }

                }
                return temp;
            }
        }

    }
}
