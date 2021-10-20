using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace CsharpConcepts9._0
{
    class Topic6
    {
        public override string ToString()
        {
            return nameof(Topic6);
        }
        public virtual Topic6 MethodToOverride()
        {
            return new();
        }
        public Topic6()
        {

        }
        public void Entry()
        {
            TargetTypedNew(new());
            StaticLambdaExpressions();
            CovariantReturnTypes();
            ForEachLoop();
            DiscardsAsParametersToLambdaExpressions();
            NullableLocalFunctions();
        }

        private void TargetTypedNew(Topic6 topic)
        {
            Topic6 topic6 = new(); // we can omit the type in a new expression when the created object's type is already known 
            Console.WriteLine(topic6.ToString());
        }
        private void StaticLambdaExpressions()
        {
            const double pi = 3.14;
            double val = 10;
            Task.Run(static () =>
            {
                //Console.WriteLine(val); //A static anonymous function can't capture local variables or instance state.
                Console.WriteLine(pi);
            });
        }
        private void CovariantReturnTypes()
        {
            Topic6Test topic6Test = new();
            topic6Test.MethodToOverride();
        }

        private void ForEachLoop()
        {
            Topic6Test topic6Test = new();
            foreach (var item in topic6Test)
            {
                Console.WriteLine(item);
            }
        }

        private void DiscardsAsParametersToLambdaExpressions()
        {
            Func<int, int> func = (_) => { return 10; };
            Console.WriteLine(func.Invoke(5));
        }


#nullable enable
        private void NullableLocalFunctions()
        {
            Console.WriteLine(GetUpper("shreesha"));
            [return: NotNull]string GetUpper(string s) //Did not Understand it completely
            {
                return s.ToUpper();
            }
        }
#nullable disable

    }
    class Topic6Test : Topic6
    {
        //An override method can return a type derived from the return type of the overridden base method.
        public override Topic6Test MethodToOverride()
        {
            return new();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
    }
}
