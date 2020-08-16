using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpInDepth
{
    class Chapter3
    {
        static void Murf2(string[] args)
        {
            var chapter3 = new Chapter3();
            chapter3.ObjectInitializer();
            chapter3.AnonymousType();
            chapter3.LambdaExpression();
            chapter3.ExtensionMethod();
            chapter3.QueryExpression();
        }

        /// <summary>
        /// Test object initializer
        /// </summary>
        private void ObjectInitializer()
        {
            Console.WriteLine("***OBJECT INITIALIZER***");
            var myOrder = getOrder();

            Console.WriteLine($"My order id is: { myOrder.OrderId }");
        }

        private Order getOrder()
        {
            var order = new Order
            {
                OrderId = "123",
                Customer = new Customer { Name = "John Lewis", Address = "UK"},
                Items = new List<OrderItem>
                {
                    new OrderItem { ItemId = "i-63561", ItemName = "Apple", Quantity = 2 },
                    new OrderItem { ItemId = "i-28454", ItemName = "Cake", Quantity = 1 }
                }
            };

            return order;
        }

        /// <summary>
        /// Test anonymous types
        /// </summary>
        private void AnonymousType()
        {
            Console.WriteLine("\n***ANONYMOUS TYPE***");

            var players = new []
            {
                new { Name = "David Beckham", Goals = 129},
                new { Name = "Andrea Pirlo", Goals = 73}
            };

            var playerWithMostGoals = players.OrderByDescending(x => x.Goals).FirstOrDefault();

            Console.WriteLine($"{ playerWithMostGoals.Name } has most goals in his career with { playerWithMostGoals.Goals } goals.");
        }

        /// <summary>
        /// Test lambda expressions
        /// </summary>
        private void LambdaExpression()
        {
            Console.WriteLine("\n***LAMBDA***");

            Action<string> action = (string message) => Console.WriteLine($"Message in lambda is: { message }");

            action("Hello, omega!");
        }

        /// <summary>
        /// Test extensions
        /// </summary>
        private void ExtensionMethod()
        {
            Console.WriteLine("\n***EXTENSIONS***");

            var stringWithoutHyphens = "I'm going to add a hyphen to this string";

            var stringWithHyphens = stringWithoutHyphens.AddHyphen();

            Console.WriteLine(stringWithHyphens);
        }        

        /// <summary>
        /// Test query expressions
        /// </summary>
        private void QueryExpression()
        {
            Console.WriteLine("\n***QUERY***");
            var myOrder = getOrder();

            bool containsCake = myOrder.Items.Where(x => x.ItemName == "Cake").Any();

            if (containsCake)
            {
                Console.WriteLine("I HAVE CAKE!!");
            }
        }
    }

    public class Order
    {
        public string OrderId;
        public Customer Customer;
        public List<OrderItem> Items;
    }

    public class Customer
    {
        public string Name;
        public string Address;
    }

    public class OrderItem
    {
        public string ItemId;
        public string ItemName;
        public int Quantity;
    }

    public static class StringExtension
    {
        public static string AddHyphen(this string myString)
        {
            var splitted = myString.Split(" ");

            return string.Join("-", splitted);
        }
    }
}