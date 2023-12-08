using System;

class Program
{
    static void Main(string[] args)
    {
        // Lecture
        Address lectureAddress = new Address("Main Street","Rexburg","ID",83440);
        Lecture readingLecture = new Lecture("English 101","Learn how to write like a professor.","12/12/23","10 am",lectureAddress,"Professor Johnson",300);
        Console.WriteLine("Lecture Event - ");
        readingLecture.getDetails();
        Console.WriteLine();
        readingLecture.getFullDetails();
        Console.WriteLine();
        readingLecture.shortDescription();

        // reception
        Address receptionAddress = new Address("Second Street","Salt Lake City","UT", 84044);
        Reception receptionEvent = new Reception("Wedding Reception","Wedding reception for Micheal and Rachel","12/20/23","10 am",receptionAddress,40);
        Console.WriteLine("\nReception Event - ");
        receptionEvent.getDetails();
        Console.WriteLine();
        receptionEvent.getFullDetails();
        Console.WriteLine();
        receptionEvent.shortDescription();

        // outdoor
        Address outdoorAddress = new Address("Third Street","Boise", "ID",83440);
        Outdoor outdoorEvent = new Outdoor("Basketball Tournament","Boise Basketball Tournament","12/14/23","2 pm",outdoorAddress,"Sunny");
        Console.WriteLine("\nOutdoor Event - ");
        outdoorEvent.getDetails();
        Console.WriteLine();
        outdoorEvent.getFullDetails();
        Console.WriteLine();
        outdoorEvent.shortDescription();

    }
}