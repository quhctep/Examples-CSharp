using System;

namespace Interfaces_Example
{
    class RobotBody
    {
        public int Drivers { get; private set; } // количество космонавтов
        public int MassBody { get; private set; }  // масса корпуса

        public RobotBody()
        {
            Drivers = 3;
            MassBody = 5000;
        }

        public int GetWeight() // возвращает общую массу модуля с учётом веса космонавтов
        {
            return (Drivers * 80) + MassBody;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Сообщение: ");
            Console.WriteLine(message);
            Console.WriteLine("отправлено");
        }
    }
}