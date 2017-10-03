using System;

namespace Interfaces_Example
{
    class Crawl : IMove
    {
        public int Weight { get; }
        public int Power { get; }

        public Crawl()
        {
            Weight = 2800;
            Power = 1000;
        }

        public void Start()
        {
            Console.WriteLine("Робот пополз!");
        }

        public void Stop()
        {
            Console.WriteLine("Робот приполз!");
        }
    }
}