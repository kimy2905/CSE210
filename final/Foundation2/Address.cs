class Address{
    private string Street;
    private string City;
    private string State;
    private string Country;

    public Address(string street, string city, string state, string country){
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool isUSA()
    {
        if (Country == "USA"){
            return true;
        }
        return false;
    }

    public string getAddress(){
        return $"{Street},{City},{State} {Country}";
    }


}