using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpInDepth
{
    class Chapter8
    {
        /// <summary>
        /// Test automatically implemented properties
        /// </summary>
        public void AutomaticProps()
        {
            Console.WriteLine("***AUTOMATIC PROPS***");

            var me = new Person();
            var John = new Person();
            var Emily = new Person();
            var myFriends = me.Friends;

            myFriends.Add(Emily);
            myFriends.Add(John);

            var Smith = new Person();
            var otherFriends = new List<Person>();
            otherFriends.Add(Smith);

            //me.Friends = otherFriends; // not possible - read only
            myFriends = otherFriends;
            Console.WriteLine("Hello, friends!");
        }

        public class Person
        {
            public List<Person> Friends { get; } =
                new List<Person>();
        }

        /// <summary>
        /// Test expression-bodied members
        /// </summary>
        public void ExpressionMembers()
        {
            Console.WriteLine("\n***EXPRESSION MEMBERS***");

            var myPoint = new Point(3.4, 8.6);

            Console.WriteLine(myPoint.DistanceFromOrigin);
        }

        public struct Point
        {
            public double X { get; }
            public double Y { get; }

            public Point(double x, double y)
            {
                X = x; 
                Y = y;
            }

            public double DistanceFromOrigin =>
                Math.Sqrt(X*X + Y*Y);
        }
    }
}