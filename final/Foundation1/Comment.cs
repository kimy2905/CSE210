class Comment{
    private string Author;
    private string Content;
    public Comment(string content, string author){
        Author = author;
        Content = content;
    }

    public string getComment(){
        return Content;
    }
}