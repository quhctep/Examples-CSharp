using System;

namespace Interfaces_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            robot.Body = new RobotBody();

            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Тестирование роботов:");
            Console.WriteLine(new String('-', 25)+"\n");

            Console.WriteLine("Робот 1:");
            robot.Move = new Run();
            robot.Move.Start();
            Console.WriteLine("Скорость: " + SpecialNasaMethod(robot.Move.Power, robot.Weight));
            robot.Move.Stop();
            Console.WriteLine(new String('-', 25) + "\n");

            Console.WriteLine("Робот 2:");
            robot.Move = new Fly();
            robot.Move.Start();
            Console.WriteLine("Скорость: " + SpecialNasaMethod(robot.Move.Power, robot.Weight));
            robot.Move.Stop();
            Console.WriteLine(new String('-', 25) + "\n");

            Console.WriteLine("Робот 3:");
            robot.Move = new Swim();
            robot.Move.Start();
            Console.WriteLine("Скорость: " + SpecialNasaMethod(robot.Move.Power, robot.Weight));
            robot.Move.Stop();
            Console.WriteLine(new String('-', 25) + "\n");

            Console.WriteLine("Робот 4:");
            robot.Move = new Crawl();
            robot.Move.Start();
            Console.WriteLine("Скорость: " + SpecialNasaMethod(robot.Move.Power, robot.Weight));
            robot.Move.Stop();
            Console.WriteLine(new String('-', 25) + "\n");

            Console.WriteLine("Робот 5:");
            robot.Move = new Station();
            robot.Move.Start();
            Console.WriteLine("Скорость: " + SpecialNasaMethod(robot.Move.Power, robot.Weight));
            robot.Move.Stop();
            Console.WriteLine(new String('-', 25) + "\n");

            Console.ReadKey();

        }


        public static int SpecialNasaMethod(int power, int mass) // метод для вычисления максимальной скорости
        {
            return (power * 100 / mass);
        }
    }
}
