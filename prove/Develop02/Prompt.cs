using System;
using System.IO;

public class Prompt
{
    public string _prompt1 = "What would you like to do tomorrow?";
    public string _prompt2 = "Describe the day in a few words";
    public string _prompt3 = "What did you learn from you activities today?";
    public string _prompt4 = "Where you able to feel the Holy Spirit today? ";
    public string _prompt5 = "What would you have done different?";
    public List<string> _prompt = new List<string>();
    public string DisplayPrompt()
    {
        var random = new Random();
        return _prompt[random.Next(_prompt.Count)];
    }  
}