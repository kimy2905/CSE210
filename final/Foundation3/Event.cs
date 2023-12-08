class Event{
    protected string title;
    protected string description;
    protected string date;
    protected string time;
    protected string type;
    protected Address address;
    public Event(string title, string description, string date, string time, Address address){
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public void getDetails(){
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Time: {time}");
        Console.WriteLine($"Address: {address.getAddress()}");
    }

    public void shortDescription(){
        Console.WriteLine($"Type: {type}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Date: {date}");
    }
}