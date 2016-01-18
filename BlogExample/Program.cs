using System;

namespace BlogExample
{
    class Program
    {
        // 1 Declaration of a delegate type
        public delegate void PersonEatsDelegate(); 

        static void Main()
        {
            // 3 Instantiation of a delegate (short form)
            PersonEatsDelegate personEatsDelegate = Person.Eats;

            // 3 Instantiation of a delegate (long form)
            PersonEatsDelegate personEatsDelegate1 = new PersonEatsDelegate(Person.Eats);


            //4 Invocation of delegate
            personEatsDelegate();
        }
    }

    public class Person
    {
        // 2 Method compatible with PersonEatsDelegate
        public static void Eats()
        {
            Console.WriteLine("The person eats!");
        }

        public static void Says(string message)
        {
            // Some implementation
        }
    }


}
