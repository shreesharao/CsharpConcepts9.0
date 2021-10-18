using System;

namespace CsharpConcepts9._0
{
    class Topic4
    {
        public void Entry()
        {
            Console.WriteLine("Type patterns");
            TestTypePatterns();
            Console.WriteLine(TestParanthesis(','));
            Console.WriteLine(TestRelationalPatterns(','));
        }

        void TestTypePatterns()
        {
            var msg = "hello";
            if (msg is string message)
                Console.WriteLine(message);
        }

        bool TestParanthesis(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';

        bool TestRelationalPatterns(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
    }


}
