using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.PD3
{
    internal class Shiritori
    {
        List<string> words = [];
        public bool GameOver = false;

        public dynamic Play(string word)
        {
            if (words.Count != 0)
            {
                string previousWord = words[words.Count - 1];
                if (word[word.Length - 1] != previousWord[previousWord.Length - 1])
                {
                    GameOver = false;
                    return "game over";
                }
            }
            words.Add(word);
            return words;
        }

        public string Restart()
        {
            words = [];
            GameOver = false;
            return "game restarted";
        }
    }
}
