using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuessNumberGame.Interfaces;

namespace GuessNumberGame.Services
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void WriteLine(string message)
        {
            var currentTime = DateTime.Now.ToShortTimeString();
            Console.WriteLine($"{currentTime}: {message}");
        }
    }
}