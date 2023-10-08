public class Journal{
    private List<Entry> _entries = new List<Entry>();

    public int displayMenu() {
        Console.WriteLine();
        Console.WriteLine("Please select one of the following options");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.Write("What would you like to do? ");
        int answer = int.Parse(Console.ReadLine());

        while (answer < 1 || answer > 5)
        {
            Console.WriteLine("Choice is not valid, please try again.");
            Console.Write("What would you like to do? ");
            answer = int.Parse(Console.ReadLine());
        }

        return answer;
    }
    
    public void addEntry(Entry entry) {
        _entries.Add(entry);
    }

    public void displayEntries()
    {
        Console.WriteLine("Journal:");
        int counter = 1;
        foreach (Entry entry in _entries){
            Console.WriteLine($"{counter}. {entry.getResponse()}");
            counter++;
        }
    }

    public void saveToFile(string filename)
    {
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine(entry.getResponse());
            }
        } 
    }

    public void readFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            entry.setResponse(line);
            _entries.Add(entry);
        }
    }


}