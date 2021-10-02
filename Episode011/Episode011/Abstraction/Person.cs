using System;
namespace Episode011.Abstraction
{
    public abstract class Person
    {
        public string FullName { get; set; }
        public void DoSomething() {
            Console.WriteLine("Do Something");
        }
    }
}
