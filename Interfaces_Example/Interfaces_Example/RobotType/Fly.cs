using System;

namespace Interfaces_Example
{
    class Fly : IMove
    {
        public int Weight { get; }
        public int Power { get; }

        public Fly()
        {
            Weight = 900;
            Power = 7000;
        }

        public void Start()
        {
            Console.WriteLine("Робот полетел!");
        }

        public void Stop()
        {
            Console.WriteLine("Робот прилетел!");
        }
    }
}