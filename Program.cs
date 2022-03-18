PriceCalculator calculator = new();

var item1 = new Item("Product 1", 200, 2);
var item2 = new Item("Product 2", 300);
var item3 = new Item("Product 3", 500, 3);

item1.DiscountRules.Add(new BuyTwoGetOneFreeDiscountRule());

var cartItems = new List<Item>()
{
    item1,
    item2,
    item3
};

var total = calculator.CalculatePrice(cartItems);

Console.WriteLine(total);