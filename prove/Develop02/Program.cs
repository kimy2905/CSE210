using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal App!");
        Journal journal = new Journal();

        // Display menu
        int choice = journal.displayMenu();

        while (choice != 5)
        {
            if (choice == 1)
            {
                Console.WriteLine();
                Entry entry = new Entry();
                string prompt = entry.getRandomPrompt();
                entry.setPrompt(prompt);
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                entry.setResponse(response);

                DateTime date = DateTime.Now;
                string dateText = date.ToShortDateString();
                entry.setDate(dateText);
                journal.addEntry(entry);
            }
            if (choice == 2)
            {
                Console.WriteLine();
                journal.displayEntries();
            }
            if (choice == 4)
            {
                Console.WriteLine();
                Console.Write("What would you like to name the file (end with .txt)? ");
                string filename = Console.ReadLine();
                journal.saveToFile(filename);
            }
            if (choice == 3)
            {
                Console.WriteLine();
                Console.Write("What is the name of the file where the journal is located? ");
                string filename = Console.ReadLine();
                journal.readFile(filename);
            }

            choice = journal.displayMenu();
        }

    }
}