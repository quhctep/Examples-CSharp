using System;

namespace Interfaces_Example
{
    class Run : IMove
    {
        public int Weight { get; }
        public int Power { get; }

        public Run()
        {
            Weight = 1000;
            Power = 3000;
        }

        public void Start()
        {
            Console.WriteLine("Робот побежал!");
        }

        public void Stop()
        {
            Console.WriteLine("Робот прибежал!");
        }
    }
}