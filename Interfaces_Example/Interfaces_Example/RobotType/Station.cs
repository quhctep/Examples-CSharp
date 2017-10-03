using System;

namespace Interfaces_Example
{
    class Station : IMove
    {
        public int Weight { get; }
        public int Power { get; }

        public Station()
        {
            Weight = 5500;
            Power = 0;
        }

        public void Start()
        {
            Console.WriteLine("Робот включился!");
        }

        public void Stop()
        {
            Console.WriteLine("Робот выключился!");
        }
    }
}