namespace Week04._2.Mostenire
{
    // Programmer - clasa derivata
    public class Programmer : Employee
    {
        public Programmer() : base("default")
        {
        }

        public Programmer(string nume) : base(nume)
        {
        }

        public Programmer(string nume, string tech) : base(nume)
        {
            this.Technology = tech;
        }

        public string Technology { get; set; }

        public void Print()
        {
            //var x = this.someProtectedField; //accesam prop / meth din instanta curenta
            //var y = base.AgeProp; //accesam prop / meth din clasa de baza
        }
    }

    public class SuperProgrammer : Programmer
    {
        public SuperProgrammer() : base("nume 2", "c#")
        {
        }

        public SuperProgrammer(string name) : base(name, "c#")
        {
        }
    }
}