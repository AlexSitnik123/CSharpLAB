using System;

namespace LAB_10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student s = new Student("Nikola", "Tesla", new DateTime(1925, 6, 11), Education.Master, "ip71", 123432);
            Console.WriteLine(s);
            try {
                s.id = 9999;
            }
            catch (IdException e) {
                Console.WriteLine(e.Message);
            }

            Examination[] exams = {
                new Examination(),
                new Examination(2, "Physics", "Skibinskiy S. V.", 71, "diff", new DateTime()),
                new Examination(1, "OOP", "Mukha S. V.", 72, "nonDiff", new DateTime()),
                new Examination(2, "Philosophy", "Ivanets S. V.", 61, "nonDiff", new DateTime())
            };

            s.AddExams(exams);
            s.PrintFullInfo();

            Console.WriteLine();

            int age = s.Age();

            Console.WriteLine("Age: " + age);
        }
    }
}
