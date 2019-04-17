using System.ComponentModel.Composition;

namespace ExternalClassLibrary
{
    [Export]
    public class Class1
    {
        public void Foo()
        {
            System.Console.WriteLine("ExternalClassLibrary.Class1.Foo()");
        }
    }
}
