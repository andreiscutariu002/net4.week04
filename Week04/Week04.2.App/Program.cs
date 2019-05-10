namespace Week04._2.App
{
    using System;
    using System.Collections.Specialized;

    class Motor
    {
        public decimal Capacitate { get; set; }
    }

    class Masina
    {
        public static int NrMasini = 0;

        public static void PrintNrMasini()
        {
            Console.WriteLine($"Nr masini (instante): {NrMasini}");
        }

        public Masina()
        {
            NrMasini = NrMasini + 1;
        }

        public string Nume { get; set; }

        public Motor Motor { get; set; }

        public void Print()
        {
            Console.WriteLine($"Nume: {this.Nume}. Cap: {this.Motor.Capacitate}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Masina.PrintNrMasini();

            var masina = new Masina();

            masina.Nume = "Dacia";

            masina.Motor = new Motor();
            masina.Motor.Capacitate = 1.8m;

            masina.Print();

            var masina2 = new Masina();

            masina2.Nume = "M";

            masina2.Motor = new Motor();
            masina2.Motor.Capacitate = 2.8m;

            masina2.Print();

            //masina2.PrintNrMasini();
            //masina2.NrMasini;

            Masina.PrintNrMasini();
        }
    }
}
