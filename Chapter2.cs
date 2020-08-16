using System;
using System.Collections.Generic;

namespace CSharpInDepth
{
    class Chapter2
    {
        /// <summary>
        /// Test generics
        /// </summary>
        public void Generics()
        {
            Console.WriteLine("***GENERICS***");

            TestGeneric<int> intGeneric = new TestGeneric<int>();
            var stringGeneric = new TestGeneric<string>();            

            intGeneric.Increment();
            stringGeneric.Increment();
            intGeneric.Increment();

            intGeneric.Display();
            stringGeneric.Display();

            var teamsList = GetTeams();
            teamsList.Add("Inter Milan");
            PrintTeams(teamsList);
            Console.WriteLine($"String default value within square brackets: [{ default(string) }]");
            Console.WriteLine($"Integer default value within square brackets: [{ default(int) }]");
        }

        private static List<string> GetTeams()
        {
            List<string> teams = new List<string>();
            teams.Add("Manchester United");
            teams.Add("Kobenhavn");

            return teams;
        }

        private static void PrintTeams(List<string> teams)
        {            
            foreach (var team in teams)
            {                
                Console.WriteLine(team);
            }
        }

        /// <summary>
        /// Test nullables
        /// </summary>
        public void Nullables()
        {
            Console.WriteLine("\n***NULLABLES***");

            PrintNullIntCheck(0, null);

            PrintNullIntCheck(1, 2);
        }

        private static void PrintNullIntCheck(int notNull, int? nullInt)
        {
            if (nullInt.HasValue)
            {
                Console.WriteLine($"{nameof(nullInt)} value is {nullInt.Value}");
            }
            else
            {
                Console.WriteLine($"{nameof(nullInt)} value is null");
            }

            Console.WriteLine($"{nameof(notNull)} value is {notNull}");
        }

        /// <summary>
        /// Test delegates
        /// </summary>
        public void Delegates()
        {
            Console.WriteLine("\n***DELEGATES***");

            string printDelegate = "Printing a string from a delegate";

            StringPrinter stringPrinter = PrintAnything;
            stringPrinter(printDelegate);
        }

        private delegate void StringPrinter(string message);
        private void PrintAnything(Object obj)
        {
            Console.WriteLine(obj);
        }

        /// <summary>
        /// Test yields
        /// </summary>
        public void Yields()
        {            
            Console.WriteLine("\n***YIELDS***");            

            foreach (var value in Iterator())
            {
                Console.WriteLine($"Returned value from Iterator: { value }");
            }
        }

        static IEnumerable<string> Iterator()
        {
            try
            {
                Console.WriteLine("Before first yield");
                yield return "first";
                Console.WriteLine("Between yields");
                yield return "second";
                Console.WriteLine("After second yield");
            }
            finally
            {                
                Console.WriteLine("Finally block");
            }
        }
    }

    class TestGeneric<T>
    {
        private int value;

        void GenericCounter()
        {
            Console.WriteLine($"Init counter for { typeof(T) }");
        }

        public void Increment()
        {
            value++;
        }

        public void Display()
        {
            Console.WriteLine($"Counter for { typeof(T) }: {value}");
        }
    }
}
