using System;

namespace LAB_10
{
    class Examination : IMarkName
    {
        public int semester;
        public string examName;
        public string teacher;
        public int grade;
        public string examType;
        public DateTime date;

        public Examination()
        {
            this.semester = 1;
            this.examName = "Philosophy";
            this.teacher = "Tereshchenko S.M.";
            this.grade = 75;
            this.examType = "diff";
            this.date = new DateTime(2018, 12, 31);

        }

        public Examination(int semester, string examName, string teacher, int grade, string examType, DateTime date)
        {
            this.semester = semester;
            this.examName = examName;
            this.teacher = teacher;
            this.grade = grade;
            this.examType = examType;
            this.date = date;
        
        } 

        public override string ToString()
        {
            return $"Subject: {this.examName}, Teacher: {this.teacher}, Grade: {this.grade}, National: {NationalScaleName()}, ECTS: {EctsScaleName()}, Term: {this.semester}";
        }

        public string NationalScaleName()
        {
            if (this.grade >= 0 && this.grade < 60) return "Незадовільно";
            if (this.grade >= 60 && this.grade < 65) return "Достатньо";
            if (this.grade >= 65 && this.grade < 75) return "Задовільно";
            if (this.grade >= 75 && this.grade < 85) return "Добре";
            if (this.grade >= 85 && this.grade < 95) return "Дуже добре"; 
            if (this.grade >= 95 && this.grade <= 100) return "Відмінно";
            return "Некоректно вказана оцінка";
        }

        public string EctsScaleName()
        {
            if (this.grade >= 0 && this.grade < 60) return "F";
            if (this.grade >= 60 && this.grade < 65) return "E";
            if (this.grade >= 65 && this.grade < 75) return "D";
            if (this.grade >= 75 && this.grade < 85) return "C";
            if (this.grade >= 85 && this.grade < 95) return "B"; 
            if (this.grade >= 95 && this.grade <= 100) return "A";
            return "Некоректно вказана оцінка";
        }

        public static Boolean operator < (Examination e1, Examination e2)
        {
            if (e1.semester < e2.semester) return true;
            return false;
        }

        public static Boolean operator > (Examination e1, Examination e2)
        {
            if (e1.semester > e2.semester) return true;
            return false;
        }

    }
}