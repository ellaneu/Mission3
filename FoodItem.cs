namespace Mission3;

public class FoodItem
{
    public string Name { get; } 
    public string Category { get; }
    public int Quantity { get; }
    public DateTime ExpirationDate { get; }

    public FoodItem(string name, string category, int quantity, DateTime expirationDate)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpirationDate = expirationDate;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Category: {Category}, Quantity: {Quantity}, Expiration Date: {ExpirationDate.ToShortDateString()}");
    }
}