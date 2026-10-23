// See https://aka.ms/new-console-template for more information
Item itemOne = new Item();
itemOne.Name = "Laptop";
itemOne.Price = 999.99;
itemOne.DiscountCode = "ABCDE";
Console.WriteLine($"Discount Rate: {Item.DiscountRate * 100}%");
itemOne.Display();
class Item
{
    public string Name { get; set; }
    public double Price { get; set; }

    private string _discountCode;

    public string DiscountCode
    {
        get { return _discountCode; }
        set
        {
            if (value.Length == 5)
            {
                _discountCode = value;
            }
            else
            {
                throw new ArgumentException("Discount code must be 5 characters long.");
            }
        }
    }

    public static double DiscountRate {get; set;} = 0.1; // 10% discount

    public void Display()
    {
        Console.WriteLine($"Item: {Name}, Price: {Price}, Discount Code: {DiscountCode}");
    }
}