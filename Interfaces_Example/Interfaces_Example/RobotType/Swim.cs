using System;

namespace Interfaces_Example
{
    class Swim : IMove
    {
        public int Weight { get; }
        public int Power { get; }

        public Swim()
        {
            Weight = 1200;
            Power = 2000;
        }

        public void Start()
        {
            Console.WriteLine("Робот поплыл!");
        }

        public void Stop()
        {
            Console.WriteLine("Робот приплыл!");
        }
    }
}