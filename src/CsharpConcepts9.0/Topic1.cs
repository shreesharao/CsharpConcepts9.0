using System;

namespace CsharpConcepts9._0
{
    class Topic1
    {
        public void Entry()
        {
            var rec1 = new Topic1Record("Shreesha", "Rao");
            //rec1.FirstName = "OtherName"; //Init-only property or indexer 'Topic1_Record.FirstName' can only be assigned in an object initializer
            // or on 'this' or 'base' in an instance constructor or an 'init' accessor.
            Console.WriteLine(rec1); // results in - Topic1_Record { FirstName = Shreesha, LastName = Rao } because of inbuilt ToString()

            var person = new Topic1Person();
            Console.WriteLine(person);

            // value equality
            var person1 = new Topic1Record("A", "B");
            var person2 = new Topic1Record("A", "B");
            Console.WriteLine($"person1 == person2 {person1 == person2}"); //this gives True but a class type would have given False here

            //Nondestructive mutation
            var person3 = new Topic1Record("A", "B");
            var person4 = person3 with { LastName = "C" };
            Console.WriteLine(person4);

            //Inheritance and value equality
            Topic1Person teacher = new Topic1Person { FirstName = "A", LastName = "B" };
            Topic1Student student = new Topic1Student { FirstName = "A", LastName = "B" };
            Console.WriteLine($"teacher == student {teacher == student}"); //this gives False because runtime types are different

            Topic1Person student2 = new Topic1Student { FirstName = "A", LastName = "B" };
            Console.WriteLine($"student == student2 {student == student2}"); //this gives True because runtime types are same which is Topic1Student
        }
    }

    record Topic1Record(string FirstName, string LastName); //this internally creates auto implemented properties and a constructor

    record Topic1Person
    {
        public string FirstName { get; init; } = default!;
        public string LastName { get; init; } = default;
    }

    record Topic1Student : Topic1Person
    {

    }
}
