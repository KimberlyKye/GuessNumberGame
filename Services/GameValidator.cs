using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuessNumberGame.Interfaces;
using GuessNumberGame.Models;

namespace GuessNumberGame.Services
{
    public class GameValidator : IGameValidator
    {
        private GameSettings settings;

        public GameValidator(GameSettings settings)
        {
            this.settings = settings;
        }
    }
}