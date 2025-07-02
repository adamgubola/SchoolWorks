using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZooTask
{
    public class Cage
    {

        private Animal[] animals;
        private int countOfanimals;

        public Cage(int size)
        {
            if (size > 10) size = 10;

            animals = new Animal[size];
            this.countOfanimals = 0;


        }

        public Cage(string path)
        {
            int num = Directory.GetFiles(path, "*.txt").Length;

            if (num > 0)
            {
                string[] file = new string[num];


                for (int j = 0; j < num; j++)
                {
                    file = Directory.GetFiles($"{path}.{j}");
                }
                for (int k = 0; k < num; k++)
                {

                    string[] lines = File.ReadAllLines(file[k]);
                    int size = lines.Length;

                    if (size > 10) size = 10;

                    animals = new Animal[size];
                    this.countOfanimals = 0;

                    for (int i = 0; i < size; i++)
                    {
                        string line = lines[i];
                        this.Add(new Animal(line));
                    }
                }
            }

        }

        public bool Add(Animal animal)
        {

            if (animals.Length > countOfanimals) {

                this.animals[countOfanimals] = new Animal(animal.Name, animal.Gender, animal.Weight, animal.Species);

                this.countOfanimals++;

                return true;
            }
            return false;
        }

        public void DeleteWithoutOffset(string name) {

            for (int i = 0; i < animals.Length; i++)
            {

                if (animals[i].Name.ToLower().Trim() == name.ToLower().Trim())
                {

                    animals[i] = animals[--countOfanimals];
                    --i;

                }
            }
        }

        public int NumberOfSpeciesTipe(Species species)
        {
            int counter = 0;

            for (int i = 0; i < animals.Length; i++) {

                if (this.animals[i].Species == species)
                {
                    counter += 1;
                }
            }
            return counter;
        }
        public int NumberOfGenderTipe(Species species, bool gender)
        {
            int counter = 0;

            for (int i = 0; i < animals.Length; i++)
            {

                if (this.animals[i].Species == species &&
                    this.animals[i].Gender == gender)
                {
                    counter += 1;
                }
            }
            return counter;
        }

        public Animal[] GetAnimalsBySpecies (Species species)
        {
            Animal[] specAnimals = new Animal[NumberOfSpeciesTipe(species)];

            int indexer = 0;

            for (int i = 0; i < countOfanimals; i++) {

                if (this.animals[i].Species == species)
                {
                    specAnimals[indexer]= this.animals[i];
                    indexer++;
                }

            }
            return specAnimals;
        } 

        public double GetAnimalWeight(Species species)
        {
            Animal[] temp = this.GetAnimalsBySpecies(species);

            double AwgWeight = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                    AwgWeight += temp[i].Weight;
             }

            return AwgWeight/temp.Length;
        }

        public bool GetDifferentGenderFromSpecies(Species species)
        {
            Animal[] temp = this.GetAnimalsBySpecies(species);

            int male = 0;
            int female = 0;

            for (int i = 0; i < temp.Length; i++)
            {

                if (temp[i].Gender == true)
                {
                    male++;
                }
                else if (temp[i].Gender == false)
                {
                    female++;
                }


            }
            if (male != 0 && female != 0) return true;

            return false;
        }

        public static Cage HighestAnimalsInCages(Cage cage1, Cage cage2, Species species)
        {
            int cageOneNum = cage1.NumberOfSpeciesTipe(species);
            int cageTwoNum = cage2.NumberOfSpeciesTipe(species);


            if( cageOneNum > cageTwoNum) { return cage1; };

            return cage2;

         }

        public void Print()
        {
            string result = string.Empty;

            for (int i = 0; i < this.countOfanimals; i++)
            {

                result += this.animals[i].Print() + "\n";

            }
            Console.WriteLine(result);

        }


        }
}
