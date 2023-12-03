using System;
using System.Reflection.Metadata;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Scripture[] scriptures = new Scripture[4];
        Scripture scripture1 = new Scripture();
        scripture1.setReference("Proverbs",3,0,"5-6");
        scripture1.setVerse("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him,and he shall direct thy paths.");
        Scripture scripture2 = new Scripture();
        scripture2.setReference("Proverbs",14,29);
        scripture2.setVerse("He that is slow to wrath is of great understanding.");
        Scripture scripture3 = new Scripture();
        scripture3.setReference("Alma",34,31);
        scripture3.setVerse("But that ye have patience, and bear with those afflictions, with a firm hope that ye shall one day rest from all your afflictions.");
        Scripture scripture4 = new Scripture();
        scripture4.setReference("Psalm",35,9);
        scripture4.setVerse("And my soul shall be joyful in the Lord: it shall rejoice in his salvation.");
        scriptures[0] = scripture1;
        scriptures[1] = scripture2;
        scriptures[2] = scripture3;
        scriptures[3] = scripture4;

        Random generator = new Random();
        int index = generator.Next(0,scriptures.Length);
        
        Console.Clear();
        Scripture scripture = scriptures[index];
        scripture.displayScripture();
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        string input = Console.ReadLine();

        while (scripture.notAllWordsHidden() == true && input != "quit")
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