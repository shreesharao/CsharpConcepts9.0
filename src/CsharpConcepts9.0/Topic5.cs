using System;

namespace CsharpConcepts9._0
{
    class Topic5
    {
        public void Entry()
        {
            NativeSizedIntegers();
            FunctionPointers();
            localsinitflag();

        }

        [System.Runtime.CompilerServices.SkipLocalsInit]
        unsafe private void localsinitflag()
        {
            int i;
            Console.WriteLine(*&i); //// Displays random value as the local variable is not automatically initialized with the default value now.
        }

        void NativeSizedIntegers()
        {
            nint x = 3;
            nuint y = 3;
            Console.WriteLine(nint.Equals(x, 3));
            Console.WriteLine($"{x.GetType()}, {3.GetType()}");
            Console.WriteLine(y.GetType());
        }

        unsafe void FunctionPointers()
        {
            delegate*<int, void> fn = &Log;
            fn(10);
        }
        static void Log(int i)
        {
            Console.WriteLine(i);
        }
    }
}
