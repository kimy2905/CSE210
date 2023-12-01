using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> listOfVideos = new List<Video>();

        Video butterBTS = new Video("Butter","BTS",400);
        butterBTS.addComment(new Comment("I loved this song!","George R."));
        butterBTS.addComment(new Comment("This song was alright.", "Leon P."));
        butterBTS.addComment(new Comment("I can't stop dancing to this song.","Abigail M."));

        Video hymnColdplay = new Video("Hymn for the Weekend","Coldplay",430);
        hymnColdplay.addComment(new Comment("I didn't really like this song.","Micheal A."));
        hymnColdplay.addComment(new Comment("I can't get this song out of my head.","Trey L."));
        hymnColdplay.addComment(new Comment("I'd love to go to their concert.","Kim A."));

        Video jackLovin = new Video("Lovin On Me","Jack Harlow",520);
        jackLovin.addComment(new Comment("Jack Harlow has nice hair.","Emilio P."));
        jackLovin.addComment(new Comment("I love the beat of this song.","Diego M."));
        jackLovin.addComment(new Comment("I didn't really like this song.","Mason L."));

        Video millionLana = new Video("Million Dollar Man","Lana Del Rey",330);
        millionLana.addComment(new Comment("Lana is beautiful.","Kimberly M."));
        millionLana.addComment(new Comment("I though this music was okay.","Nelson M."));
        millionLana.addComment(new Comment("I love her music!","Jason O."));

        butterBTS.display();
        hymnColdplay.display();
        jackLovin.display();
        millionLana.display();
    }
}