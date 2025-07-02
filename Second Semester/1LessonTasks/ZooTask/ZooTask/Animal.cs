using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ZooTask
{
    public class Animal
    {
        private string name;
        private bool gender;
        private int weight;
        private Species species;
        


        public string Name { get { return name; }
                            private set { this.name = value; }
        }
       
        public bool Gender { get { return gender; }
                             private set { this.Gender = value; }
        }
        public int Weight { get { return weight; }
                            private set { this.Weight = value; }
        }
        public Species Species { get { return species; }
                                private set { this.Species = value; }
        }

        public Animal(string name, bool gender, int weight, Species species)
        {
            this.name = name;
            this.gender = gender;
            this.weight = weight;
            this.species = species;
        }

        public Animal(string detailedAnimals) : this (detailedAnimals.Split(':'))
        {
                
        }

        public Animal(string[]splitted):this(

            splitted[0],
            splitted[1] == "male" ? true : false,
            int.Parse(splitted[2]),
            (Species)Enum.Parse(typeof(Species), splitted[3],true)
                                  
            )
        {
            
        }

        public string Print()
        {
            return $"name: {this.Name}, geder: {(this.Gender? "male": "female")}, weight: {this.Weight}, " +
                   $"species: {this.Species} ";
        }
    }
}
