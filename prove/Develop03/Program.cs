using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> scripture = new Dictionary<string, string>
            {
                { "reference", "Mosiah 3:8" },
                { "text", "And he shall be called Jesus Christ, the Son of God, the Father of heaven and earth, the Creator of all things from the beginning; and his mother shall be called Mary." }
            };

            List<string> words = scripture["text"].Split(' ').ToList();
            int totalWords = words.Count;

            Console.Clear();
            Console.WriteLine("{0}: {1}", scripture["reference"], scripture["text"]);
            Console.WriteLine("Press Enter or type quit:");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }
                Console.Clear();
                int hiddenWords = totalWords - words.Count;
                int toHide = Math.Min(words.Count, 3);
                for (int i = 0; i < toHide; i++)
                {
                    int index = new Random().Next(words.Count);
                    words[index] = "_";
                }

                Console.WriteLine("{0}: ", scripture["reference"]);
                Console.WriteLine("{0}", string.Join(" ", words), hiddenWords, totalWords);
                Console.WriteLine("Press Enter or type quit:");
            }
        }
    }

