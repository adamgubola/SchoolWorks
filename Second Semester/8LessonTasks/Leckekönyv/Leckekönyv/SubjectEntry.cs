using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Leckekönyv
{
    public class SubjectEntry
    {
        public string Name { get; private set; }
        public Etype Type { get; private set; }
        public int Grade { get; private set; }

        public SubjectEntry(string name, Etype type, int grade)
        {
            Name = name;
            Type = type;
            Grade = grade;
        }

        public SubjectEntry(string[] input):this(
            input[0].Trim(),
            (Etype)Enum.Parse(typeof(Etype), input[1].Trim(), true),
            int.Parse(input[2].Trim()))
        {

        }

        public SubjectEntry(string input):this(input.Split(':')) 
        {
        }
      

        public static SubjectEntry Parse(string str)
        {
           
            SubjectEntry subjectEntry = new SubjectEntry(str);
            

            return subjectEntry;
        }
    }
}
