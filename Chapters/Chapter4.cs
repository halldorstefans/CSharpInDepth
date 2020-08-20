using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpInDepth
{
    class Chapter4
    {
        /// <summary>
        /// Test dynamic typung
        /// </summary>
        public void DynamicTyping()
        {
            Console.WriteLine("***DYNAMIC TYPING***");

            PrintAddition("Hello");
            PrintAddition(5);
            PrintAddition(3.14);
        }

        static void PrintAddition(dynamic d)
        {
            Console.WriteLine(d + d);
        }

        /// <summary>
        /// Test optional parameters and named arguments
        /// </summary>
        public void OptionalParametersNamedArguments()
        {
            Console.WriteLine("\n***OPTIONAL PARAMETERS***");

            MyMethod(1);
            MyMethod(1, 5);
            MyMethod(parm3: -5, parm1: 7);
            MyMethod(1, 2, 3);
        }

        static void MyMethod(int parm1, int parm2 = 10, int parm3 = 100)
        {
            Console.WriteLine($"Parm1 = { parm1 }; Parm2 = { parm2 }; Parm3 = { parm3 }");
        }
    }
}