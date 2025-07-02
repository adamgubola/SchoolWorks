using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCosts
{
    public class YearlyCosts
    {
        public MonthlyCosts[] Costs { get; set; } = new MonthlyCosts[12];

        public static YearlyCosts LoadFrom(string folderName)
        {
            if (!Directory.Exists(folderName)) throw new DirectoryNotFoundException();

            YearlyCosts result = new YearlyCosts();
            foreach (string filename in Directory.GetFiles(folderName))
            {
                int index = int.Parse(filename.Substring(filename.Length - 6, 2));
                result.Costs[index] = MonthlyCosts.LoadFrom(filename);
            }
            return result;
        }

        public TrainingType _Type { get; private set; }

        public MonthlyCosts MaxCost()
        {

            if (this.Costs.Length == 0) { throw new ZeroLengthArrayException(); }

            MonthlyCosts monthlyCosts = this.Costs[0];

            for (int i = 1; i < this.Costs.Length; i++)
            {
                if (this.Costs[i] != null && monthlyCosts.Sum() < this.Costs[i].Sum())
                {
                    monthlyCosts = this.Costs[i];
                }
            }
            return monthlyCosts;
        }

        public MonthlyCosts MaxCostWhen(TrainingType trainingType)
        {

            if (this.Costs.Length == 0) { throw new ZeroLengthArrayException(); }

            this._Type = trainingType;
            MonthlyCosts monthlyCosts = this.Costs[0];

            for (int i = 1; i < this.Costs.Length; i++)
            {
                if (this.Costs[i] != null && monthlyCosts.SumWhenCost(When) < this.Costs[i].SumWhenCost(When))
                {
                    monthlyCosts = this.Costs[i];
                }
            }
            return monthlyCosts;
        }
        public bool When(TrainingCost trainingCost)
        {
            if (trainingCost.Type == this._Type)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TrainingCost[] SimilarTypeAndDesc(MonthlyCosts costs1, MonthlyCosts costs2, Predicate<TrainingCost> predicate)
        {

            TrainingCost[] trainingTypes = new TrainingCost[costs1.TrainingCosts.Length];
            int counter = 0;

            if (costs1.TrainingCosts.Length == 0 || costs2.TrainingCosts.Length == 0)
            {

                throw new ZeroLengthArrayException();
            }

            for (int i = 0; i < costs1.TrainingCosts.Length; i++)
            {
                for (int j = 0; j < costs2.TrainingCosts.Length; j++)
                {
                    if (predicate.Invoke(costs1.TrainingCosts[i]) && predicate.Invoke(costs2.TrainingCosts[j]))
                    {
                        if (costs1.TrainingCosts[i].Description.Equals(costs2.TrainingCosts[j].Description))
                        {
                            trainingTypes[counter] = costs2.TrainingCosts[j];
                            counter++;
                        }


                    }
                }

            }
            Array.Resize(ref trainingTypes, counter);

            return trainingTypes;
        }

        public int[] HowManyPerTypes()
        {
            TrainingType[] temp = (TrainingType[])Enum.GetValues(typeof(TrainingType));

            int[] result = new int[temp.Length];

            for (int i = 0; i < this.Costs.Length; i++)
            {
                for(int j = 0;j < temp.Length; j++)
                {
                    if (this.Costs[i] != null)
                    {
                        this._Type = temp[j];
                        result[j] += this.Costs[i].HowMany(When);
                    }

                }
            }

            return result;

        }
    }
}
