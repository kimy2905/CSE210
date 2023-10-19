using System;
using System.Reflection.Metadata;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture scripture = new Scripture();
        scripture.setReference("Proverbs",3,0,"5-6");
        scripture.setVerse("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him,and he shall direct thy paths.");
        scripture.displayScripture();
        Console.WriteLine();
        Console.WriteLine("Press any key to continue or type 'quit' to finish");
        string input = Console.ReadLine();

        while (input != "quit")
        {  
            Console.Clear();
            scripture.hideWords();
            scripture.displayScripture();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue or type 'quit' to finish");
            input = Console.ReadLine();
        }
    }
}