// using System.IO;
public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)

    {
        _entries.Add(newEntry);
        Console.WriteLine("Your entry has been added successfully to your Journal!");
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display");
            return;
        }
        foreach (Entry entry in _entries)
        {
            string memo = entry.Display();     // call the display method from class Entry
            Console.WriteLine(memo);    
        }
    }

    public void SaveToFile(string filename)
    {

        Console.WriteLine("Saving to file...");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }

        Console.WriteLine($"Journal saved to {filename}.");

    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found");
            return;
        }
        _entries.Clear(); // Clear existing entries before loading new ones
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split("|");
                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };
                    _entries.Add(entry);
                }
            }
        }

        Console.WriteLine($"Journal loaded from {filename}.");
    }
}