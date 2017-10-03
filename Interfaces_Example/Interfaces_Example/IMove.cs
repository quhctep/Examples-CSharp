using System;

namespace Interfaces_Example
{
    interface IMove
    {
        void Start();       // метод для запуска
        void Stop();        // метод для остановки
        int Weight { get; } // масса двигателя 
        int Power { get; }  // мощность двигателя
    }
}