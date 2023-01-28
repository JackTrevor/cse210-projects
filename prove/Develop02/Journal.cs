using System;
using System.IO; 
public class Journal
{
    public string _fileName;
    public List<Entry> _entries = new List<Entry>();
    public void DisplayJournal()
    {   
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();         
        }
    }
    public void SaveFile()
    {
        Console.WriteLine("What are you going to call this one? ");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} - {entry._promptQuestion} - {entry._userResponse}");
            }
        }
    }
    public void LoadFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            Entry theEntry = new Entry();
            string[] parts = line.Split("-");
            theEntry._date = parts[0];
            theEntry._promptQuestion = parts[1];
            theEntry._userResponse = parts[2];
            _entries.Add(theEntry);
        }
        DisplayJournal();
    }
}