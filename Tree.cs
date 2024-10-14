// Tree.cs
public class Tree : Plant, IPlant
{
    private double price;
    private int quantity;

    public Tree(string name, string about, double price, int quantity)
        : base(name, about)
    {
        this.price = price;
        this.quantity = quantity;
    }

    // Реалізація методу Get_Price
    public double Get_Price()
    {
        return price;
    }

    // Реалізація методу Count
    public int Count()
    {
        return quantity;
    }
}