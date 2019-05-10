using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04._2.Mostenire
{
    class Program
    {
        static void Main(string[] args)
        {
            //var p = new Programmer("Andrei");

            //var m = new Manager();

            //p.Metoda(2);

            //m.Metoda(3);

            var sp = new SuperProgrammer();

            sp.SetAge(22);

            sp.AgeProp = 17;

            var age = sp.GetAge();
        }
    }
}
