using DesignPatternUsage.Abstractions;

namespace DesignPatternUsage;

/// <summary>
/// Represents a indivisual item
/// </summary>
public class Item
{
    public string ItemName { get; init; }
    public decimal ActualPrice { get; init; }
    public decimal Quantity { get; set; }

    /// <summary>
    /// Collection of discount on given item
    /// </summary>
    public List<IDiscountRule> Discounts { get; set; }

    public Item(string name, decimal price, int purchasedQuantity = 1)
    {
        ItemName = name;
        ActualPrice = price;
        Discounts = new List<IDiscountRule>();
        Quantity = purchasedQuantity;
    }

    public decimal GetFinalPriceAfterDiscount(List<Item> purchasedItems)
    {
        if (Discounts.Count == 0)
        {
            return ActualPrice * Quantity;
        }
        else
        {
            var tempPrice = ActualPrice;

            foreach (var discount in Discounts)
            {
                tempPrice = discount.GetDiscountPrice(this, purchasedItems);
            }

            return tempPrice;
        }
    }
}
