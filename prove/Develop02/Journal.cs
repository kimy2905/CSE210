public class Journal{
    private List<Entry> Entries = new List<Entry>();

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
        Entries.Add(entry);
    }

    public void displayEntries()
    {
        Console.WriteLine("Journal:");
        foreach (Entry entry in Entries){
            Console.WriteLine($"{entry.getDate()},{entry.getPrompt()},{entry.getResponse()}");
        }
    }

    public void saveToFile(string filename)
    {
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Entry entry in Entries)
            {

                outputfile.WriteLine($"{entry.getDate()},{entry.getPrompt()},{entry.getResponse()}");
            }
        } 
    }

    public void readFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        Entries.Clear();
        foreach (string line in lines)
        {
            string[] pieces = line.Split(",");

            Entry entry = new Entry();
            entry.setDate(pieces[0]);
            entry.setPrompt(pieces[1]);
            entry.setResponse(pieces[2]);
            Entries.Add(entry);
        }
    }


}