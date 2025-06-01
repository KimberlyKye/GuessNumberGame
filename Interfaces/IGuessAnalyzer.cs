using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuessNumberGame.Models;

namespace GuessNumberGame.Interfaces
{
    /// <summary>
    /// Принцип разделения интерфейсов (ISP).
    /// Мелкие специализированные интерфейсы.
    /// </summary>
    public interface IGuessAnalyzer
    {
        GuessResult Analyze(int targetNumber, int guess);
    }
}