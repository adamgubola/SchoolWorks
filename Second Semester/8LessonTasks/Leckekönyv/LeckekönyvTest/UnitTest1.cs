using Leckekönyv;

namespace LeckekönyvTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void maxGradeInActualSemesterInStudentArrayTest()
        {
            string inp1 = "Gipsz Jakab; BATM4N; 2022/23/1@SZTF1: Banned: 1 & DIMAT:Exam: 4 & FZK:MidYearMark: 3#2022/23/2@SZTF1:Exam:1#2024/25/1@SZTF1:Exam:5";
            string inp2 = "Kiss Pál; K1SSPL; 2024/25/2@SZFA: Exam: 5#2024/25/2@ALGA:Exam:4";
            string inp3 = "Gipsz Jakab2; 222222; 2022/23/1@SZTF1: Banned: 1 & DIMAT:Exam: 4 & FZK:MidYearMark: 3#2022/23/2@SZTF1:Exam:1#2024/25/1@SZTF1:Exam:3";

            Student[] students = new Student[3] { new Student(inp1), new Student(inp2), new Student(inp3) };



            Assert.That(Student.MaxGradeInActualSemesterInStudentArray(students, Student.SemesterCheck, "2022/23/1", Semester.SubjectCeck, "SZTF1"), Is.EqualTo(1));
            Assert.That(Student.MaxGradeInActualSemesterInStudentArray(students, Student.SemesterCheck, "2024/25/1", Semester.SubjectCeck, "SZTF1"), Is.EqualTo(5));

        }

        [Test]
        public void maxGradeInAllSemesterInStudentArrayTest()
        {
            string inp1 = "Gipsz Jakab; BATM4N; 2022/23/1@SZTF1: Banned: 1 & DIMAT:Exam: 4 & FZK:MidYearMark: 3#2022/23/2@SZTF1:Exam:1#2024/25/1@SZTF1:Exam:5";
            string inp2 = "Kiss Pál; K1SSPL; 2024/25/2@SZFA: Exam: 5#2024/25/2@ALGA:Exam:4";
            string inp3 = "Gipsz Jakab2; 222222; 2022/23/1@SZTF1: Banned: 1 & DIMAT:Exam: 4 & FZK:MidYearMark: 3#2022/23/2@SZTF1:Exam:1#2024/25/1@SZTF1:Exam:3";

            Student[] students = new Student[3] { new Student(inp1), new Student(inp2), new Student(inp3) };



            Assert.That(Student.MaxGradeInAllSemesterInStudentArray(students,Semester.SubjectCeck, "SZTF1"), Is.EqualTo(5));
            Assert.That(Student.MaxGradeInAllSemesterInStudentArray(students,Semester.SubjectCeck, "ALGA"), Is.EqualTo(4));

        }

        [Test]

        public void ActaulStudentActualSubjectSixTimesTest()
        {
            string inp1 = "Gipsz Jakab; BATM4N; 2022/23/1@SZTF1: Banned: 1 & DIMAT:Exam: 4 & FZK:MidYearMark: 3#2022/23/2@SZTF1:Exam:1#2024/25/1@SZTF1:Exam:5";
            string inp2 = "Kiss Pál; K1SSPL; 2024/25/2@SZFA: Exam: 5#2024/25/2@ALGA:Exam:4";
            string inp3 = "Gipsz Jakab2; 222222; 2022/23/1@SZTF1: Banned: 1 & DIMAT:Exam: 4 & FZK:MidYearMark: 3#2022/23/2@SZTF1:Exam:1#2024/25/1@SZTF1:Exam:3";

            Student[] students = new Student[3] { new Student(inp1), new Student(inp2), new Student(inp3) };

            Assert.That(students[0].ActaulStudentActualSubjectSixTimes(x => x.StudentName == "Gipsz Jakab", "SZFT1"), Is.EqualTo(false));
        }

    }
}