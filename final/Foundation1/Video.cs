using System.Transactions;

class Video{
    private string Title;
    private string Author;
    private int Length;
    private List<Comment> listOfComments = new List<Comment>();

    public Video(string title, string author, int length){
        Title = title;
        Author = author;
        Length = length;
    }

    public void addComment(Comment comment){
        listOfComments.Add(comment);
    }

    public void display(){
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length}");
        Console.WriteLine($"Number of Comments: {listOfComments.Count}");
        Console.WriteLine("Comments:");
        int index = 1;
        foreach (Comment comment in listOfComments)
        {
            Console.WriteLine($"{index}. {comment.getComment()}");
        }
        Console.WriteLine();
    }

}