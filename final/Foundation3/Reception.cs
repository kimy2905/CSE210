class Reception : Event{
    private int registered;
    public Reception(string title, string description, string date, string time, Address address, int registered) : base(title,description,date,time,address){
        this.registered = registered;
    }
    public void getFullDetails(){
        getDetails();
        Console.WriteLine($"Registered: {registered}");
    }
}