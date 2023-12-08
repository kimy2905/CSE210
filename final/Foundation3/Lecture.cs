class Lecture : Event{
    private string speaker;
    private int capacity;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title,description,date,time,address){
        this.speaker = speaker;
        this.capacity = capacity;
        type = "Lecture Event";
    }

    public void getFullDetails(){
        getDetails();
        Console.WriteLine($"Speaker: {speaker}");
        Console.WriteLine($"Capacity: {capacity}");
    }
}