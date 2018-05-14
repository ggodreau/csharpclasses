using System;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            System.Console.WriteLine("Hi {0}, my name is {1}", to, Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Greg";
            person.Introduce("Buttface");
        }
    }
}