using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuessNumberGame.Interfaces;

namespace GuessNumberGame.Models
{
    /// <summary>
    /// Принцип инверсии зависимостей (DI).
    /// Класс Game зависит от абстракций, а не от конкретных реализаций
    /// </summary>
    public class Game
    {
        private readonly IGameSettings _settings;
        private readonly IRandomNumberGenerator _generator;
        private readonly IGuessAnalyzer _analyzer;
        private readonly IInputReader _inputReader;
        private readonly IOutputWriter _outputWriter;
        private readonly IGameValidator _validator;

        public Game(IGameSettings settings,
                   IRandomNumberGenerator generator,
                   IGuessAnalyzer analyzer,
                   IInputReader inputReader,
                   IOutputWriter outputWriter,
                   IGameValidator validator)
        {
            _settings = settings;
            _generator = generator;
            _analyzer = analyzer;
            _inputReader = inputReader;
            _outputWriter = outputWriter;
            _validator = validator;
        }

        public void Play()
        {
            var randomNumber = _generator.Generate(_settings.MinNumber, _settings.MaxNumber);
            var isSuccess = false;

            while (!isSuccess)
            {
                Console.WriteLine($"Введите число от {_settings.MinNumber} до {_settings.MaxNumber}:");
                var checkNumberStr = Console.ReadLine();
                try
                {
                    if (String.IsNullOrWhiteSpace(checkNumberStr))
                    {
                        throw new ArgumentNullException("Необходимо ввести число!");
                    }

                    var isParseOk = Int32.TryParse(checkNumberStr, out var checkNumber);
                    if (!isParseOk)
                    {
                        throw new ArgumentException("Не удалось распознать число!");
                    }

                    var guessResult = _analyzer.Analyze(randomNumber, checkNumber);

                    switch (guessResult)
                    {
                        case GuessResult.TooHigh:
                            Console.WriteLine("Загаданное число меньше.");
                            break;
                        case GuessResult.TooLow:
                            Console.WriteLine("Загаданное число больше.");
                            break;
                        case GuessResult.Correct:
                            isSuccess = true;
                            Console.WriteLine($"Вы угадали! Загаданное число: {checkNumber}");
                            break;
                        default:
                            throw new InvalidOperationException($"Неизвестный результат угадывания: {guessResult}");
                    }
                }
                catch (Exception ex)
                {
                    isSuccess = false;
                    switch (ex)
                    {
                        case InvalidOperationException:
                        case ArgumentNullException:
                        case ArgumentException:
                            Console.WriteLine(ex.Message);
                            break;

                        default:
                            Console.WriteLine($"Произошла непредвиденная ошибка: {ex.GetType()}. {ex.Message}");
                            break;
                    }
                }
            }
        }
    }
}