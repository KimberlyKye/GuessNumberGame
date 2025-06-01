// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;
using GuessNumberGame.Models;
using GuessNumberGame.Services;

var settings = new GameSettings(minNumber: 1, maxNumber: 100, maxAttempts: 10);
var generator = new GuessNumberGame.Services.RandomNumberGenerator();
var analyzer = new GuessAnalyzer();
var validator = new GameValidator(settings);
var inputReader = new ConsoleInputReader();
var outputWriter = new ConsoleOutputWriter();

var game = new Game(settings, generator, analyzer, inputReader, outputWriter, validator);
game.Play();
