using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>()
            {
                new Person("Farrux","Shonazarov","Muzaffar o'g'li",20),
            };
            var name = person.Select(p => new
            {
                fullName = $"{p.lName} {p.fName} {p.mName}",
                year = DateTime.Now.Year - p.age
            });
            foreach (var i in name)
            {
                Console.WriteLine($"{i.fullName} - {i.year}-yil ");
            }

            Console.ReadKey();
        }


        class Person
        {
            public string fName { get; set; }
            public string lName { get; set; }
            public string mName { get; set; }
            public int age { get; set; }

            public Person(string fName, string lName, string mName, int age)
            {
                this.fName = fName;
                this.lName = lName;
                this.mName = mName;
                this.age = age;
            }
        }
    }
}
