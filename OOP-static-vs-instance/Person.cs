using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_static_vs_instance
{
    public class Person
    {
        public string FirstName;

        public string LastName;

        public static int TotalPopulation;

        public const int MaxPopulationCount = 1000;

        public void Print()
        {
            //this. pentru membri de instanta
            //Class. folosit pentru membri statici
            Console.WriteLine($"Person: {this.FirstName} {this.LastName} {Person.TotalPopulation}");
        }

        public static void PrintTotalPopulation()
        {
            Console.WriteLine($"Total populations is: {Person.TotalPopulation}");
        }

        public static void PrintPerson(Person p)
        {
            Console.WriteLine($"Person is: {p.FirstName} {p.LastName}");
        }
    }
}
