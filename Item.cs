

public class Item
{
    public string ItemName { get; init; }
    public decimal ActualPrice { get; init; }
    public decimal PurchasedQuantity { get; init; }

    public List<IDiscountRule> DiscountRules { get; set; }

    public Item(string name, decimal price, int purchasedQuantity = 1)
    {
        ItemName = name;
        ActualPrice = price;
        DiscountRules = new List<IDiscountRule>();
        PurchasedQuantity = purchasedQuantity;
    }

    public decimal GetFinalPriceAfterDiscount(List<Item> purchasedItems)
    {
        if (DiscountRules.Count == 0)
        {
            return ActualPrice;
        }
        else 
        {
            var tempPrice = ActualPrice;

            foreach(var discount in DiscountRules) 
            {
                discount.ApplyRule(purchasedItems);
            }
        }
    }
}