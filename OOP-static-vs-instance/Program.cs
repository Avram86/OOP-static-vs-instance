using System;

namespace OOP_static_vs_instance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "John";
            person1.LastName = "Doe";
            Person.TotalPopulation = 1;

            Person person2 = new Person();
            person2.FirstName = "Mary";
            person2.LastName = "Doe";
            Person.TotalPopulation = 2;

            Console.WriteLine($"Person1: {person1.FirstName} {person1.LastName} {Person.TotalPopulation}");
            Console.WriteLine($"Person2: {person2.FirstName} {person2.LastName} {Person.TotalPopulation}");
        }
    }
}
