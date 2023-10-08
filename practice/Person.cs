public class Person
{

    //attributes
    public string _givenName = "";
    public string _familyName = "";
    public int _age = 0;

    // constructor
    public Person() { }

    //metodos
    public void showEasternName()
    {
        Console.Writeline(_givenName);
    }
    public void showWeasternName()
    {
        Console.Writeline(_familyName);
    }
}

