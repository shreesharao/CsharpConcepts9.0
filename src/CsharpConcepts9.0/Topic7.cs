using System;
using System.Runtime.CompilerServices;

namespace CsharpConcepts9._0
{
    public class Topic7
    {
        [ModuleInitializer]
        public static void ModuleInitializer()
        {
            Console.WriteLine("Initializing module.");
        }
        public void Entry()
        {
            Console.WriteLine("Entry method called");
            var topic7Test = new Topic7Test();
            topic7Test.OnSomethingHappened("Method invoked");
        }
    }

    partial class Topic7Test
    {
        public partial void OnSomethingHappened(string s);
    }

    // This part can be in a separate file.
    partial class Topic7Test
    {
        // Comment out this method and the program will not compile. If it's private then program will compile
        public partial void OnSomethingHappened(string s)
        {
            Console.WriteLine("Something happened: {0}", s);
        }
    }
}
