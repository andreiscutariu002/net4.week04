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
            var p = new Programmer("Andrei");

            var m = new Manager();

            var sp = new SuperProgrammer();

            p.Metoda(2);

            m.Metoda(3);


            sp.SetAge(22);

            sp.AgeProp = 17;

            var age = sp.GetAge();

            List<Employee> employees = new List<Employee>();

            employees.Add(m);
            employees.Add(p);
            employees.Add(sp);

            foreach (var employee in employees)
            {
            }
        }
    }
}
