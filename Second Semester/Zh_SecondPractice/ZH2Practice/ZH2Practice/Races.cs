using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ZH2Practice
{
    public class Races
    {

        public RaceResults[] race { get; private set; }
        public Races(RaceResults[] raceResults)
        {
            race = new RaceResults[raceResults.Length];

            for (int i = 0; i < raceResults.Length; i++)
            {
                race[i] = raceResults[i];
            }
        }

        public Time BestPerformance(string name)
        {
            Time best = null;

            for (int i = 0; i < race.Length; i++)
            {
                for (int j = 0; j < race[i].runnerWithTime.Length; j++)
                {
                    if (race[i].runnerWithTime[j].Name.Equals(name))
                    {
                        if (best == null)
                        {
                            best = race[i].runnerWithTime[j].TimeForRunner;
                        }
                        else if (race[i].runnerWithTime[j].TimeForRunner.CompareTo(best) > 0)
                        {
                            best = race[i].runnerWithTime[j].TimeForRunner;
                        }
                    }
                }
            }
            return best;
        }


        public RunnerWithTime[] Union(RunnerWithTime[] first, RunnerWithTime[] second)
        {
            int i = 0;
            int j = 0;
            int counter = 0;

            RunnerWithTime[] temp = new RunnerWithTime[first.Length + second.Length];

            while (i < first.Length && j < second.Length)
            {
                if (first[i].CompareTo(second[j]) <= 0)
                {
                    temp[counter] = first[i];
                    counter++;
                    i++;
                }
                else
                {
                    temp[counter] = second[j];
                    counter++;
                    j++;
                }
            }
            while (i < first.Length)
            {
                temp[counter] = first[i];
                counter++;
            }
            while (j < second.Length)
            {
                temp[counter] = second[j];
                counter++;
            }



            return temp;
        }

        public RunnerWithTime[] AllBetween(Time lower, Time upper)
        {
            int size = 0;
            int idx = 0;

            RunnerWithTime[] temp = null;

            for (int i = 0; i < this.race.Length; i++)
            {
                size += this.race[i].runnerWithTime.Length;
            }
            RunnerWithTime[] runnerWithTime = new RunnerWithTime[size];

            for (int i = 0; i < this.race.Length; i++)
            {
                temp = this.race[i].Between(lower, upper);

                for (int j = 0; j < temp.Length; j++)
                {
                    runnerWithTime[idx] = temp[j];
                    idx++;
                }

            }

            return RaceResults.Sort2(runnerWithTime);
        }
        }
    }
