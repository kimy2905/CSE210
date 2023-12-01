class Order{
    private List<Product> listOfProducts = new List<Product>();
    private Customer Customer;
    private int TotalCost;
    private int ShippingCost;

    public Order(Customer customer){
        Customer = customer;

        if (Customer.fromUSA() == true){
            ShippingCost = 5;
        }
        ShippingCost = 35;
    }

    public void packingLabel(){
        foreach (Product product in listOfProducts){
            Console.WriteLine($"{product.getName()} - {product.getId()}");
        }
    }

    public void shippingLabel(){
        Console.WriteLine($"{Customer.getName()} - {Customer.getAddress()}");
    }

    public void addProduct(Product product){
        listOfProducts.Add(product);
    }

    public double getTotalPrice(){
        double totalPrice = 0;
        foreach (Product product in listOfProducts){
            totalPrice += product.getTotalPrice();
        }
        return totalPrice;
    }
}
