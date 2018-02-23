using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProgrammingDemo
{
    public class Ticker
    {
        private readonly string _name;
        private readonly int _count;
        private readonly int _delay;
        public Ticker(string name, int count, int delay)
        {
            _name = name;
            _count = count;
            _delay = delay;
        }

        public void Count()
        {
            for (int i = 0; i < _count; i++)
            {
                Thread.Sleep(_delay);
                Console.WriteLine($"Count {i} of {_count} in thread : {Thread.CurrentContext.ContextID} in {_name}");
            }
        }

        public async Task CountAsync()
        {
            await Task.Run(() => Count());
        }
    }
}