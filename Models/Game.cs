using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuessNumberGame.Interfaces;

namespace GuessNumberGame.Models
{
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
            // Игровая логика
        }
    }
}