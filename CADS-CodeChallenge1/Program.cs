namespace CADS_CodeChallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(10, "Michael", "Jackson", new List<LessonScore> { new LessonScore() { CourseTitle = "C#", Score = 90 }, new LessonScore() { CourseTitle = "SQL", Score = 60 } });
            Student student2 = new Student(11, "Jimmy", "Kimmel", new List<LessonScore> { new LessonScore() { CourseTitle = "C#", Score = 80 } , new LessonScore() { CourseTitle="SQL", Score = 75 } , new LessonScore() { CourseTitle="VB.NET" , Score = 10 } });
            Student student3 = new Student(12, "James", "Hetfield", new List<LessonScore> { new LessonScore() { CourseTitle = "C#", Score = 40 }, new LessonScore() { CourseTitle = "SQL", Score = 100 }});
            Student student4 = new Student(12, "Kirk", "Hammett", new List<LessonScore> { new LessonScore() { CourseTitle = "C#", Score = 90 }, new LessonScore() { CourseTitle = "SQL", Score = 100 } });
            Student student5 = new Student(12, "Joe", "Satriani", new List<LessonScore> { new LessonScore() { CourseTitle = "C#", Score = 55 }, new LessonScore() { CourseTitle = "SQL", Score = 75 }, new LessonScore() { CourseTitle = "VB.NET", Score = 60 } });
        }
    }

    public class Student
    {
        public Student(int id,string firstName,string lastName, List<LessonScore> scores)
        {
            Id = id; 
            FirstName = firstName;
            LastName = lastName;
            Scores = scores;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<LessonScore> Scores { get; set; }
    }

    public class LessonScore
    {
        public string CourseTitle { get; set; }
        public double Score { get; set; }

    }
}