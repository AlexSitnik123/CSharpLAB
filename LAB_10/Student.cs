using System;
using System.Collections.Generic;

namespace LAB_10
{
    
    enum Education 
    {
        Master, 
        Bachelor, 
        SecondEducation, 
        PhD
    }
    
    class Student : Person
    {

        public Education qualificationLevel { get; set; }
        public string groupName { get; set; }
        private int _id;
        public int id 
        {
            get
            {
                return _id;
            }
            set
            {
                if ((value <= 99999) || (value > 99999999)) {
                    throw new IdException("id value should be between 99999 and 99999999");
                } 
                _id = value;
            }
        } 
        public List<Examination> passedExams { get; set; } = new List<Examination>();

        public float averageGrade
        {
            get
            {
                List<Examination> exams = passedExams.FindAll(item => item.examType == "diff");
                int summ = 0;
                foreach (Examination exam in exams) summ += exam.grade;
                return ((float)summ)/exams.Count;
            }
        }

        public Student(string name, string surname, DateTime birthday, Education qualifcationLevel, string groupName, int id) : base (name, surname, birthday)
        {
            this.qualificationLevel = qualifcationLevel;
            this.groupName = groupName;
            this._id = id;
        }

        public void AddExams(Examination[] examList)
        {
            foreach (Examination item in examList) passedExams.Add(item);
        }

        public override string ToString()
        {
            return $"\nName: {this.name}\nSurname: {this.surname}\nGroup: {this.groupName}\n";
        }

        public override void PrintFullInfo()
        {
            Console.WriteLine($"\nEducation: {this.qualificationLevel}\nGroup: {this.groupName}\nID: {this._id}\nAverage grade: {this.averageGrade}\n");
            Console.Write("Exams list: \n");
            for (int i = 0; i < passedExams.Count; i++) {
                Console.WriteLine("\t" + passedExams[i]);
            }
        }

 public IEnumerable<Examination> GetExaminations(int grade)
        {
            foreach (var exam in passedExams)
            {
                if (exam.grade >= grade)
                    yield return exam;
            }
        }

        public int Age()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - Birthday;
            return age;
        }


    }
}