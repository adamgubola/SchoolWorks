namespace Leckekönyv
{
    public class Student
    {
        public string StudentName { get; private set; }

        public string StudentNeptunCode { get; private set; }

        public Semester[] Semes { get; private set; }

        public Student(string studentName, string studentNeptunCode, string semester)
        {
            StudentName = studentName;
            StudentNeptunCode = studentNeptunCode;
            string[] temp = semester.Split('#');
            this.Semes = new Semester[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                Semes[i] = Semester.Parse(temp[i].Trim());
            }

        }

        public Student(string input) : this(input.Split(';'))
        {
        }

        public Student(string[] input) : this(
            input[0].Trim(),
            input[1].Trim(),
            input[2].Trim())
        {
        }

        public static Student Parse(string str)
        {

            Student student = new Student(str);

            return student;
        }

        public int MaxGradeInActualSemes(Func<Semester, string, bool> func, string inp, Func<SubjectEntry, string, bool> func2, string inp2)
        {
            int max = int.MinValue;

            if (this.Semes.Length > 0)
            {
                for (int i = 0; i < this.Semes.Length; i++)
                {
                    if (func.Invoke(this.Semes[i], inp))
                    {
                        int localMax = this.Semes[i].MaxGradeInSemester(func2, inp2);

                        if (localMax > max) { max = localMax; }
                    }

                }
            }
            else { throw new ArgumentNullException(); }

            return max;

        }

        public static bool SemesterCheck(Semester semester, string inp)
        {
            return semester.Identifier.ToLower().Contains(inp.ToLower());
        }

        public int MaxGradeInALLSemes(Func<SubjectEntry, string, bool> func, string inp)
        {
            int max = int.MinValue;

            if (this.Semes.Length > 0)
            {
                for (int i = 0; i < this.Semes.Length; i++)
                {

                    int localMax = this.Semes[i].MaxGradeInSemester(func, inp);

                    if (localMax > max) { max = localMax; }
                }

            }
            else { throw new ArgumentNullException(); }

            return max;

        }

        public static int MaxGradeInActualSemesterInStudentArray(Student[] stud, Func<Semester, string, bool> func, string inp, Func<SubjectEntry, string, bool> func2, string inp2)
        {
            int max = int.MinValue;
            

            if(stud.Length == 0) { throw new ArgumentNullException(); }

            for (int i = 0; i < stud.Length; i++) 
            {
                int localMax = stud[i].MaxGradeInActualSemes(func, inp, func2, inp2);
                if (localMax > max)
                {
                    max = localMax;
                }
            }

            return max;

        }

        public static int MaxGradeInAllSemesterInStudentArray(Student[] stud, Func<SubjectEntry, string, bool> func, string inp)
        {
            int max = int.MinValue;

            if (stud.Length == 0) { throw new ArgumentNullException(); }

            for (int i = 0; i < stud.Length; i++)
            {
                int localMax = stud[i].MaxGradeInALLSemes(func, inp);
                if (localMax > max)
                {
                    max = localMax;
                }
            }

            return max;

        }

        public bool ActaulStudentActualSubjectSixTimes(Predicate<Student> predicate, string inp)
        {
            int temp = 0;

            if (predicate.Invoke(this))
            {
                for (int i = 0; this.Semes.Length < 0; i++) 
                {
                    for (int j = 0; j < this.Semes[i].Subject.Length; j++)

                        if (Semes[i].Subject[j].Name.ToLower().Equals(inp.ToLower()))
                        {
                            temp++;
                            if (temp >= 6) { return true; }

                        }
                }

            }
            return temp >= 6;


        }








    }
}
