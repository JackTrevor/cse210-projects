using System;

namespace ScriptureMemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Scripture scripture = new Scripture("Mosiah 3:8", "And he shall be called Jesus Christ, the Son of God, the Father of heaven and earth, the Creator of all things from the beginning; and his mother shall be called Mary.");
            ScriptureMemoryGame game = new ScriptureMemoryGame(scripture);

            game.StartGame();
        }
    }
}
