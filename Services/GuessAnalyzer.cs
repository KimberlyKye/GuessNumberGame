using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuessNumberGame.Interfaces;
using GuessNumberGame.Models;

namespace GuessNumberGame.Services
{
    /// <summary>
    /// Принцип открытости/закрытости (OCP).
    /// Классы должны быть открыты для расширения, но закрыты для изменения.
    /// Класс анализатора угадывания чисел должен быть открыт для расширения для поддержки новых результатов угадывания, но закрыт для изменения существующего кода.
    /// </summary>
    public class GuessAnalyzer : IGuessAnalyzer
    {
        public GuessResult Analyze(int targetNumber, int guess)
        {
            if (guess == targetNumber)
                return GuessResult.Correct;

            return guess < targetNumber ? GuessResult.TooLow : GuessResult.TooHigh;
        }
    }

}