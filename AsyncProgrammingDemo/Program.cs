using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgrammingDemo
{
    class Program
    {
        static void Main()
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {
            var tasks = new List<Task>();
            var tickers = new List<Ticker>()
            {
                new Ticker("ticker1", 20, 1000),
                new Ticker("ticker2", 20, 3000)
            };
            foreach (var ticker in tickers)
            {
                tasks.Add(ticker.CountAsync());
            }
            await Task.WhenAll(tasks);
            Console.Read();
        }
    }
}
