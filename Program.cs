// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;
using GuessNumberGame.Interfaces;
using GuessNumberGame.Models;
using GuessNumberGame.Services;

// Перейдите в GameSettings для ознакомления с принципом единственной ответственности. [S]
// Перейдите в IGameSettings для ознакомления с принципом инверсии зависимостей. [I]
// IGameSettings здесь указано только для быстрого перехода. Вне рамках учебного примера я бы написала var и не приводила к типу в GameValidator.
IGameSettings settings = new GameSettings(minNumber: 1, maxNumber: 100, maxAttempts: 10);

// Перейдите в ConsoleInputReader для ознакомления с принципом открытости/закрытости. [O]
var outputWriter = new ConsoleOutputWriter();

// Перейдите в Game для ознакомления с принципом подстановки Барбары Лисков. [L]
var inputReader = new ConsoleInputReader();

var generator = new GuessNumberGame.Services.RandomNumberGenerator();
var analyzer = new GuessAnalyzer();
var validator = new GameValidator((GameSettings)settings);


// Перейдите в Game для ознакомления с принципом инверсии зависимостей. [D]
var game = new Game(settings, generator, analyzer, inputReader, outputWriter, validator);
game.Play();
