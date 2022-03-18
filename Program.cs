using DesignPatternUsage;

var cartItems = new List<Item>()
{
    new Item("Product 1", 200, 3),
    new Item("Product 2", 300),
    new Item("Product 3", 500, 3)
};

// Add discount to items
cartItems[0].Discounts.Add(new BuyTwoGetOneFreeDiscountRule());

PriceCalculator calculator = new();
var total = calculator.CalculatePrice(cartItems);

Console.WriteLine("Total Amount : " + total);

Console.ReadLine();