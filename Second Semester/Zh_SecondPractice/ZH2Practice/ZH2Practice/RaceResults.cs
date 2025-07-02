using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZH2Practice;

namespace ZH2Practice
{
    public class RaceResults
    {
        public RunnerWithTime[] runnerWithTime { get; private set; }


        public RaceResults(int runnersCount, string[] inputs)
        {
            runnerWithTime = new RunnerWithTime[runnersCount];

            for (int i = 0; i < runnersCount; i++)
            {
                runnerWithTime[i] = RunnerWithTime.Parse(inputs[i]);

            }
            if (!IsSorted())
            {
                Sort();
            }
        }


        public bool IsSorted()
        {
            bool result = true;

            for (int i = 0; i < this.runnerWithTime.Length - 1; i++)
            {
                if (this.runnerWithTime[i].CompareTo(this.runnerWithTime[i + 1]) > 0)
                {
                    result = false;
                }
            }
            return result;
        }

        public void Sort()
        {
            int i = 1;
            int j;
            RunnerWithTime temp;

            while (i < this.runnerWithTime.Length)
            {
                j = i - 1;
                temp = this.runnerWithTime[i];

                while (j >= 0 && this.runnerWithTime[j].CompareTo(temp) > 0)
                {
                    this.runnerWithTime[j + 1] = this.runnerWithTime[j];
                    j--;
                }
                this.runnerWithTime[j + 1] = temp;
                i++;

            }
        }

        public int LowerBound(Time time)
        {

            for (int i = 0; i < this.runnerWithTime.Length; i++)
            {
                if (runnerWithTime[i].TimeForRunner.CompareTo(time) <= 0)
                {

                    return i;

                }
            }
            return -1;
        }

        public int UpperBound(Time time)
        {
            for (int i = 0; i < this.runnerWithTime.Length; i++)
            {
                if (runnerWithTime[i].TimeForRunner.CompareTo(time) <= 0)
                {

                    return i;

                }
            }
            return -1;
        }
        public RunnerWithTime[] Between(Time lower, Time upper)
        {
            int low = LowerBound(lower);
            int up = UpperBound(upper);
            int size = up - low;

            RunnerWithTime[] temp = new RunnerWithTime[size];

            for (int i = low, j = 0; i < size; i++, j++)
            {
                temp[j] = this.runnerWithTime[i];
            }
            return temp;

        }

        public bool Contains(Predicate<RunnerWithTime> predicate, out RunnerWithTime runnerPerformance)
        {
            bool result = false;
            runnerPerformance = null;

            for (int i = 0; i < this.runnerWithTime.Length && !result; i++)
            {
                if (predicate(this.runnerWithTime[i]))
                {
                    runnerPerformance = this.runnerWithTime[i];
                    result = true;

                }
            }
            return result;
        }

        public static RunnerWithTime[] Sort2(RunnerWithTime[]runnerWithTimes)
        {
            int i = 1;
            int j;
            RunnerWithTime temp;

            while (i < runnerWithTimes.Length)
            {
                j = i - 1;
                temp = runnerWithTimes[i];

                while (j >= 0 && runnerWithTimes[j].CompareTo(temp) > 0)
                {
                    runnerWithTimes[j + 1] = runnerWithTimes[j];
                    j--;
                }
                runnerWithTimes[j + 1] = temp;
                i++;

            }
            return runnerWithTimes;
          
        }



    }
}
