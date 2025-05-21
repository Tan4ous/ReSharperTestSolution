using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResharperTestSolution
{
    //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-delegates

    internal class GenericDelegate
    {
        delegate void StackEventHandler<T, U>(T sender, U eventArgs);

        class Stack<T>
        {
            public class StackEventArgs : System.EventArgs { }
            public event StackEventHandler<Stack<T>, StackEventArgs>? StackEvent;

            protected virtual void OnStackChanged(StackEventArgs a)
            {
                if (StackEvent is not null)
                    StackEvent(this, a);
            }
        }

        class SampleClass
        {
            public void HandleStackChange<T>(Stack<T> stack, Stack<T>.StackEventArgs args) { }
        }

        public static void Test()
        {
            Stack<double> s = new Stack<double>();
            SampleClass o = new SampleClass();
            s.StackEvent += o.HandleStackChange;
        }
    }
}
