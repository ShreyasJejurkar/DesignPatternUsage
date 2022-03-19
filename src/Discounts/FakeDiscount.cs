using DesignPatternUsage.Abstractions;

namespace DesignPatternUsage.Discounts;

public class FakeDiscount : IDiscountRule
{
    public decimal GetDiscountPrice(Item currentItem, List<Item> purchasedItems)
    {
        return currentItem.ActualPrice * currentItem.Quantity;
    }
}
