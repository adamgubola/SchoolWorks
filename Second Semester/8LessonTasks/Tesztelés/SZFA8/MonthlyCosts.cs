using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCosts
{
    public class MonthlyCosts
    {
        public TrainingCost[] TrainingCosts { get; set; }

        public static MonthlyCosts LoadFrom(string filename)
        {
            if (!File.Exists(filename)) throw new FileNotFoundException();

            MonthlyCosts result = new MonthlyCosts();
            result.TrainingCosts = new TrainingCost[FileLength(filename)];

            using (StreamReader sr = new StreamReader(filename))
            {
                int i = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    result.TrainingCosts[i] = TrainingCost.Parse(line);
                    ++i;
                }
            }

            return result;
        }

        private static int FileLength(string filename)
        {
            return File.ReadAllLines(filename).Length;
        }

        public int Sum()
        {
            int res = 0;
            for (int i = 0; i < TrainingCosts.Length; i++)
            {
                res += TrainingCosts[i].Cost;
            }
            return res;
        }

        public int SumWhenCost(Predicate<TrainingCost> predicate)
        {
            int res = 0;
            for(int i = 0; i< TrainingCosts.Length; i++)
            {
                if (predicate.Invoke(TrainingCosts[i]))
                {
                    res += TrainingCosts[i].Cost;
                }
            }
            return res;
        }

        public bool Any(Predicate<TrainingCost> predicate)
        {
            bool res = false;
            for (int i = 0; i < TrainingCosts.Length && !res; i++)
            {
                if (predicate.Invoke(TrainingCosts[i]))
                {
                    res = true;
                }
            }
            return res;
        }

        public bool All(Func<TrainingCost, TrainingType, bool> predicate, TrainingType type)
        {
            bool res = true;
            for (int i = 0; i < TrainingCosts.Length && res; i++)
            {
                if (!predicate.Invoke(TrainingCosts[i], type))
                {
                    res = false;
                }
            }
            return res;
        }

        public bool IsThatSpent(Predicate<TrainingCost> predicate, int pieces) 
        {
            bool res = false;
            int temp = 0;

            for (int i = 0; i < this.TrainingCosts.Length && temp != pieces; i++) 
            {
                if (predicate.Invoke(TrainingCosts[i])){
                    temp++;
                }
            }
            res= temp == pieces;

            return res;
        
        }

        public bool IsThatSpentFunc(Func<TrainingCost, TrainingType, bool> predicate, TrainingType type, int pieces)
        {
            bool res = false;
            int temp = 0;

            for (int i = 0; i < this.TrainingCosts.Length && temp != pieces; i++)
            {
                if (predicate.Invoke(TrainingCosts[i], type))
                {
                    temp++;
                }
            }
            res = temp == pieces;

            return res;

        }

        public TrainingCost? WhichSpent(Predicate<TrainingCost> predicate, int pieces)
        {
            TrainingCost? training=null;

            int temp = 0;

            for (int i = 0; i < this.TrainingCosts.Length; i++)
            {
                if (predicate.Invoke(TrainingCosts[i]))
                {
                    temp++;
                    if (temp == pieces)
                    {
                        return this.TrainingCosts[i];
                    }
                }
            }
            
            return training;

        }

        public int HowMany(Predicate<TrainingCost>predicate)
        {
            int res = 0;
            for (int i = 0; i < this.TrainingCosts.Length; i++)
            {
                if (predicate.Invoke(this.TrainingCosts[i]))
                {
                    res++;
                }
            }
            return res;
        }

        public int Max() 
        {
        TrainingCost cost= this.TrainingCosts[0];

            if (this.TrainingCosts.Length == 0)
            {
                throw new ZeroLengthArrayException();
            }


                for (int i = 1;i < this.TrainingCosts.Length; i++)
                {

                    if(cost.Cost < this.TrainingCosts[i].Cost)
                     {
                        cost = this.TrainingCosts[i];
                       }
            }
            return cost.Cost;

        }
        public int[] MaxAll() {

            TrainingCost cost = this.TrainingCosts[0];
            int[]temp = new int[this.TrainingCosts.Length];
            
            int counter = 0;

            if (this.TrainingCosts.Length == 0)
            {
                throw new ZeroLengthArrayException();
            }


            for (int i = 1; i < this.TrainingCosts.Length; i++)
            {

                if (cost.Cost < this.TrainingCosts[i].Cost)
                {
                    cost = this.TrainingCosts[i];
                   
                }

            }
            for (int i = 0; i < this.TrainingCosts.Length; i++)
            {

                if (cost.Cost == this.TrainingCosts[i].Cost)
                {
                    temp[counter++] = i;

                }

            }
            Array.Resize(ref temp, counter);

            return temp;


        }

        public int[] WhichMaxAll(Predicate<TrainingCost>predicate)
        {

            TrainingCost cost = this.TrainingCosts[0];
            int[] temp = new int[this.TrainingCosts.Length];
            temp[0] = 0;
            int counter = 0;

            if (this.TrainingCosts.Length == 0)
            {
                throw new ZeroLengthArrayException();
            }

            for (int i = 1; i < this.TrainingCosts.Length && predicate.Invoke(this.TrainingCosts[i]); i++)
            {

                if (cost.Cost < this.TrainingCosts[i].Cost)
                {
                    cost = this.TrainingCosts[i];

                }

            }
            for (int i = 0; i < this.TrainingCosts.Length && predicate.Invoke(this.TrainingCosts[i]); i++)
            {

                if (cost.Cost == this.TrainingCosts[i].Cost)
                {
                    temp[counter++] = i;

                }

            }
           
            
            Array.Resize(ref temp, counter);

            return temp;


        }

        public int[] WhichAll(Predicate<TrainingCost> predicate)
        {
            int[]temp = new int[this.TrainingCosts.Length];
            int counter = 0;

            if (this.TrainingCosts.Length == 0)
            {
                throw new ZeroLengthArrayException();
            }

            
                for (int i = 0; i < this.TrainingCosts.Length; i++) {

                    if (predicate.Invoke(this.TrainingCosts[i]))
                    {
                        temp[counter]= i;
                        counter++;
                    }
                }
            Array.Resize<int>(ref temp, counter);
            return temp;

        }

        public TrainingCost[] OrderSpends(Predicate<TrainingCost> predicate)
        {
            TrainingCost[] training = this.TrainingCosts;

            TrainingCost temp = training[0];
            int jobb = training.Length-1;
            int bal = 0;

            while (bal < jobb) 
            {
                while (bal< jobb && !predicate.Invoke(training[jobb]))
                {
                    jobb--;
                }
                training[bal] = training[jobb];
                bal++;

                while(bal<jobb && predicate.Invoke(training[bal]))
                {
                    bal++;
                }
                training[jobb]=training[bal];
                jobb--;
            }

            if (predicate.Invoke(temp))
                training[jobb] = temp;
            else
                training[bal] = temp;

            return training;

        }
    }
}
