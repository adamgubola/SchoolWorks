namespace Leckekönyv
{
    public class Semester
    {
        public string Identifier { get; private set; }
        public SubjectEntry[] Subject { get; private set; }

        public Semester(string identifier, string subjectEntry)
        {
            this.Identifier = identifier;

            string[] temp = subjectEntry.Split('&');

            this.Subject = new SubjectEntry[temp.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                this.Subject[i] = SubjectEntry.Parse(temp[i].Trim());
            }
        }

        public Semester(string input) : this(input.Split('@'))
        {

        }

        public Semester(string[] input) : this(
            input[0].Trim(),
            input[1].Trim())
        {
        }

        public static Semester Parse(string str)
        {
            Semester semester = new Semester(str);

            return semester;

        }

        public int MaxGradeInSemester(Func <SubjectEntry, string, bool> func, string inp)
        {
            int max = 0;

            for (int j = 0; j < this.Subject.Length; j++)
            {
                if (func.Invoke(this.Subject[j],inp)
                    && this.Subject[j].Grade > max)
                {
                    max = this.Subject[j].Grade;
                }
            }


            return max;

        }

        public static bool SubjectCeck(SubjectEntry subject, string inp)
        {
            return subject.Name.ToLower().Contains(inp.ToLower());
        }

    }
}
