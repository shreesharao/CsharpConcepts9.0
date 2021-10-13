using System;

namespace CsharpConcepts9._0
{
    class Topic2
    {
        public void Entry()
        {
            var topic2Struct = new Topic2Struct() { FirstName = "Shreesha", LastName = "Rao" };
            var topic2Class = new Topic2Class() { FirstName = "Shreesha", LastName = "Rao" };
            var topic2Record = new Topic2Record("Shreesha", "Rao");

            Console.WriteLine(topic2Struct); // Prints CsharpConcepts9._0.Topic2Struct
            Console.WriteLine(topic2Class); //Prints CsharpConcepts9._0.Topic2Class
            Console.WriteLine(topic2Record); // Prints Topic2Record { FirstName = Shreesha, LastName = Rao }

            //topic2Struct.FirstName = "SomeOtherName" // this results in an error

        }
    }
    struct Topic2Struct
    {
        public string FirstName { get; init; }
        public string LastName { get; set; }
    }

    class Topic2Class
    {
        public string FirstName { get; init; }
        public string LastName { get; set; }

        public Topic2Class()
        {
            this.FirstName = default; //This is allowed on Init only properties
        }

        void Test()
        {
            //this.FirstName = default; //This is not allowed on Init only properties
        }
    }

    record Topic2Record(string FirstName, string LastName);
}
