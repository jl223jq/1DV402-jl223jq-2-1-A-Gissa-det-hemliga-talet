using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        public const int MaxNumberOfGuesses = 7;
        private int _number;
        private int _count;

        public void Initialize()
        { //Skapar 
            Random randomNumber = new randomNumber();
            _number = randomNumber.Next(1, 101);
            _count = 0;
        }

        public bool MakeGuess(int number)
        { //Publicering av gissningarna här

            bool guess = false;
            

            if (number > randomNumber.Next || number < randomNumber.Next)
            {
                throw new ArgumentOutOfRangeException("Sa jag inte att du bara fick gissa på ett tal mellan 1 och 100? Gissa igen nu då.");
            }
            _count++;
            if (number == _number)
            {
                Console.WriteLine("Rätt! Du använde {0} gissningar.", _count);
                guess = true;
            }
            if (number < _number)
            {
                Console.WriteLine("För lågt! Du har {0] gissningar kvar", _count);
            }
            if (number > _number)
            {
                Console.WriteLine("För högt! Du har {0] gissningar kvar", _count);
            }
            
            
            if (_count > MaxNumberOfGuesses)
            {
                throw new ApplicationException("Du har redan fått dina 7 gissningar.");
            }
            return guess;
        }


        public SecretNumber()
        {//Konstruktor
            Initialize();
        }
    }
}
