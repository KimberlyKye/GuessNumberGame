using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuessNumberGame.Interfaces;

namespace GuessNumberGame.Models
{
    /// <summary>
    /// Принцип единственной ответственности (SRP).
    /// Каждый класс имеет только одну причину для изменения.
    /// Ответственность класса заключается в хранении настроек игры.  
    /// </summary>
    public class GameSettings : IGameSettings
    {
        public int MinNumber { get; }
        public int MaxNumber { get; }
        public int MaxAttempts { get; }

        public GameSettings(int minNumber, int maxNumber, int maxAttempts)
        {
            MinNumber = minNumber;
            MaxNumber = maxNumber;
            MaxAttempts = maxAttempts;
        }
    }
}