namespace Week04._2.Mostenire
{
    using System;

    // Manager - clasa derivata
    public class Manager : Employee
    {
        public Manager() : base("nume default")
        {
        }

        public string Department { get; set; }

        public void Print()
        {
            //Console.WriteLine($"Name {this.Name}." +
            //                  $" AgeProp {this.AgeProp}." +
            //                  $" Department {this.Department}.");

            base.Print();

            Console.WriteLine($"Dep: {this.Department}");
        }
    }
}