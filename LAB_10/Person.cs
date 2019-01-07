using System;


namespace LAB_10
{
    class Person 
    {
        protected string name;
        protected string surname;
        private DateTime _birthday;
        public int Birthday
        {
            get
            {
                return _birthday.Year;
            }
            set
            {
                _birthday = new DateTime(value, _birthday.Month, _birthday.Day);
            }
        }

        public Person(string name, string surname, DateTime birthday) 
        {
            this.name = name;
            this.surname = surname;
            this._birthday = birthday;
        }

        public Person()
        {
            this.name = "Oleksiy";
            this.surname = "Sitnik";
            this._birthday = new DateTime(2000, 6, 11);
        }

        public virtual void PrintFullInfo() 
        {
            Console.WriteLine($"Name: {this.name}\nsurname: {this.surname}\nbirth date: {this._birthday.ToString()}");
        }

    }

}