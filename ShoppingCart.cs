public class ShoppingCart
{
    public List<Item> PurchasedItems { get; set; }
    public Dictionary<Item, List<IDiscountRule>> DiscountRules { get; set; }

    public void AddItemsWithDiscount(Item item, int quantity, IDiscountRule discount)
    {
        PurchasedItems.Add(item);
        DiscountRules.Add(item, new List<IDiscountRule>() { discount });
    }

    public void AddItem(Item item)
    {

    }

}