public class Pizza
{
    private string _name;
    private int _diameter;
    private double _price;

    public Pizza(string name, int diameter, double price)
    {
        _name = name;
        _diameter = diameter;
        _price = price;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    
    public int Diameter
    {
        get { return _diameter; }
        set { _diameter = value; }
    }
    
    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }
}
