using System.Transactions;

class Video{
    private string title;
    private string author;
    private int length;
    private List<Comment> listOfComments = new List<Comment>();

    public Video(string title, string author, int length){
        this.title = title;
        this.author = author;
        this.length = length;
    }

    public void addComment(Comment comment){
        listOfComments.Add(comment);
    }

    public void display(){
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {length}");
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