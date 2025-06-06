using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuessNumberGame.Interfaces;

namespace GuessNumberGame.Services
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        public int Generate(int min, int max)
        {
            var rnd = new Random();
            return rnd.Next(min, max);
        }
    }
}