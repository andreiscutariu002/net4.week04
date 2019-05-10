namespace Week04._2.Mostenire
{
    using System;

    public class Employee // clasa de baza
    {
        public Employee(string nume)
        {
            this.Name = nume;
        }

        public void Metoda(int var)
        {
        }

        public string Name { get; set; }

        public int AgeProp
        {
            get
            {
                return this.ageProp;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine($"Not ok");
                }

                //this.ageProp = value;
            } 
        }

        private int ageField;

        public void SetAge(int age)
        {
            this.ageField = age;
        }

        public int GetAge()
        {
            return this.ageField;
        }

        private int ageProp;

        protected void Print()
        {
            Console.WriteLine($"Name {this.Name}. " +
                              $"AgeProp {this.AgeProp}.");
        }
    }
}