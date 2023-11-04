using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Activity program = new Activity();
        int input = program.menu();

        while (input != 4)
        {
            if (input == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.start();
            }
            else if (input == 2)
            {
                ReflectingActivity reflection = new ReflectingActivity();
                reflection.start();
            }
            else if (input == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.start();
            }
            input = program.menu();
        }
    }
}