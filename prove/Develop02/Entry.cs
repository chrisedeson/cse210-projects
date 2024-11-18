public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string Display()
    {
        string log = $"Date: {_date} - Prompt: {_promptText}\n{_entryText}\n";
        // Console.WriteLine(log);
        return log;
    }
}