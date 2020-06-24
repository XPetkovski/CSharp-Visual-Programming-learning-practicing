using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV7
{
    public class HangmanWord
    {
        public string Word { get; set; }
        public HashSet<char> allLetter { get; set; }
        public HashSet<char> wordLetters { get; set; }
        public int WrongAttempts { get; set; }
        public static readonly int MAX_ATTEMPTS = 5;

        public HangmanWord(string Word)
        {
            this.Word = Word;
            allLetter = new HashSet<char>();
            wordLetters = new HashSet<char>();
            foreach(char c in Word)
            {
                wordLetters.Add(char.ToLower(c));
            }
            WrongAttempts = 0;
        }

        public bool IsGuessed
        {
            get
            {
                return wordLetters.Count == 0;
            }
        }
        public bool GameOver
        {
            get
            {
                return WrongAttempts == MAX_ATTEMPTS;
            }
        }

        public bool guessLetter(char letter)
        {
            letter = char.ToLower(letter);

            if(allLetter.Contains(letter))
            {
                return false;
            }
            else
            {
                allLetter.Add(letter);
            }
            if(wordLetters.Contains(letter))
            {
                wordLetters.Remove(letter);
                return true;
            }
            else
            {
                ++WrongAttempts;
                return true;
            }
        }

        public string wordMask()
        {
            StringBuilder sb = new StringBuilder();

            foreach(char c in Word)
            {
                char tmp = char.ToLower(c);
                if(wordLetters.Contains(tmp))
                {
                    sb.Append("_ ");
                }
                else
                {
                    sb.Append(c);
                }
                sb.Append(" ");
            }
            return sb.ToString();
        }
        public string guessedLetterMask()
        {
            StringBuilder sb = new StringBuilder();
            for(char c = 'a'; c<= 'z'; c++)
            {
                if(allLetter.Contains(c))
                {
                    sb.Append(c);
                }
                else
                {
                    sb.Append("_ ");
                }
                sb.Append(" ");
            }
            return sb.ToString();
        }

        internal void endGame()
        {
            
            //throw new NotImplementedException();
        }
    }
}
