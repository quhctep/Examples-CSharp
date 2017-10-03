using System;

namespace Interfaces_Example
{
    class Robot
    {
        public RobotBody Body { get; set; } // головная часть
        public IMove Move { get; set; }      // двигатель

        public int Weight
        {
            get
            {
                return Body.GetWeight() + Move.Weight; // масса головной части + масса движка + масса космонавтов
            }
        }
    }
}