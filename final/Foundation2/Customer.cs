class Customer{
    private string Name;
    private Address _Address;
    public Customer(string name, Address address){
        Name = name;
        _Address = address;
    }

    public bool fromUSA(){
        if (_Address.isUSA() == true){
            return true;
        }
        return false;
    }

    public string getName(){
        return Name;
    }

    public string getAddress(){
        return _Address.getAddress();
    }

}