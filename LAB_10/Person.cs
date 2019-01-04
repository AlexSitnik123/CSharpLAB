using System;


namespace LAB_10
{
    class Person 
    {
        protected string name;
        protected string surname;
        public DateTime birthday { get; set; }

        public Person(string name, string surname, DateTime birthday) 
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
        }

        public Person()
        {
            this.name = "Oleksiy";
            this.surname = "Sitnik";
            this.birthday = new DateTime(2000, 6, 11);
        }

        public virtual void PrintFullInfo() 
        {
            Console.WriteLine($"Name: {this.name}\nsurname: {this.surname}\nbirth date: {this.birthday}");
        }

    }

}