using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessNumberGame.Interfaces
{
    /// <summary>
    /// Принцип разделения интерфейсов (ISP).
    /// Мелкие специализированные интерфейсы.
    /// </summary>
    public interface IGameSettings
    {
        int MinNumber { get; }
        int MaxNumber { get; }
        int MaxAttempts { get; }
    }
}