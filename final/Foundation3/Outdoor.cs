class Outdoor : Event{
    private string forecast;
    public Outdoor(string title, string description, string date, string time, Address address, string forecast) : base(title,description,date,time,address){
        this.forecast = forecast;
    }

    public void getFullDetails(){
        getDetails();
        Console.WriteLine($"Forecast: {forecast}");
    }
}