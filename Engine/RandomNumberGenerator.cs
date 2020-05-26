using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        //none deterministic version of RNG
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        public static int NumberBetween(int minimuValue, int maximumValue)
        {
            byte[] randomNumber = new byte[1];

            _generator.GetBytes(randomNumber);

            double asciiValueofRandomCharacter = Convert.ToDouble(randomNumber[0]);

            //Math to ensure it's always between 0.0 and 0.9999999 as "1" causes problems
            double multiplier = Math.Max(0, (asciiValueofRandomCharacter / 255d) - 0.00000000001d);

            //We need to add one to the range to allow for the round done with math.floor
            int range = maximumValue - minimuValue + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(minimuValue + randomValueInRange);
        }

        //Simple random generator that is more easily predicted
        //not used just here if I want to use it

        private static readonly Random _simpleGenerator = new Random();

        public static int SimpleNumberBetweeen(int minimumValue, int maximumValue)
        {
            return _simpleGenerator.Next(minimumValue, maximumValue + 1);
        }
    }
}
