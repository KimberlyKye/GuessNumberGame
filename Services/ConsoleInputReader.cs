using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuessNumberGame.Interfaces;

namespace GuessNumberGame.Services
{
    /// <summary>
    /// Принцип подстановки Барбары Лисков (LSP).
    // Подклассы могут заменять базовые классы.
    // Класс ConsoleInputReader реализует интерфейс IInputReader, который содержит метод ReadLine(). 
    /// </summary>
    public class ConsoleInputReader : IInputReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}