using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemoryGame
{
    public class ScriptureMemoryGame
    {
        private readonly Scripture _scripture;
        private List<string> _hiddenWords;
        private int _totalWords;

        public ScriptureMemoryGame(Scripture scripture)
        {
            _scripture = scripture;
            _hiddenWords = _scripture.Text.Split(' ').ToList();
            _totalWords = _hiddenWords.Count;
        }

        public void StartGame()
        {
            Console.Clear();
            Console.WriteLine(_scripture);
            Console.WriteLine("Press Enter or type quit:");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }
                Console.Clear();
                int hiddenWordsCount = _totalWords - _hiddenWords.Count;
                int wordsToHideCount = Math.Min(_hiddenWords.Count, 3);
                for (int i = 0; i < wordsToHideCount; i++)
                {
                    int index = new Random().Next(_hiddenWords.Count);
                    _hiddenWords[index] = "_";
                }

                Console.WriteLine($"{_scripture.Reference}: {string.Join(" ", _hiddenWords)} ({hiddenWordsCount} words hidden out of {_totalWords})");
                Console.WriteLine("Press Enter or type quit:");

                if (_hiddenWords.All(word => word == "_"))
                {
                    break;
                }
            }
        }
    }
}
