class Comment{
    private string author;
    private string content;
    public Comment(string content, string author){
        this.author = author;
        this.content = content;
    }

    public string getComment(){
        return content;
    }
}