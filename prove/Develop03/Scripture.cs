using System;

namespace ScriptureMemoryGame
{
    public class Scripture
    {
        public string Reference { get; }
        public string Text { get; }

        public Scripture(string reference, string text)
        {
            Reference = reference;
            Text = text;
        }

        public override string ToString()
        {
            return $"{Reference}: {Text}";
        }
    }
}
