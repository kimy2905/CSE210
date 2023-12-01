using System.Data.Common;

class Product{
    private string Name;
    private int Id;
    private double Price;
    private int Quantity;

    public Product(string name, int id, double price, int quantity){
        Name = name;
        Id = id;
        Price = price;
        Quantity = quantity;
    }

    public double getTotalPrice(){
        return Price * Quantity;
    }

    public string getName(){
        return Name;
    }

    public int getId(){
        return Id;
    }
}