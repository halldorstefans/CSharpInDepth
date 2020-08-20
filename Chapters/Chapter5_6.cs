using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpInDepth
{
    class Chapter5_6
    {
        /// <summary>
        /// Test aync await
        /// </summary>
        public async void AsyncAwait()
        {
            Console.WriteLine("***ASYNC AWAIT***");

            var todo = GetToDoList();

            var task = OrderPizzaAsync();   

            StartToDoList(todo); // To various things while waiting for pizza

            var pizza = await task;

            Console.WriteLine(pizza);
        }

        private List<string> GetToDoList()
        {
            return new List<string>
            {
                "Watch TV",
                "Do laundry"
            };
        }

        private void StartToDoList(List<string> todo)
        {
            foreach (var item in todo)
            {
                Console.WriteLine(item);
            }

            Thread.Sleep(10);
        }

        private async Task<string> OrderPizzaAsync()
        {
            Console.WriteLine("Placing order");
            await Task.Delay(1);
            return "Pizza ready";
        }
    }
}