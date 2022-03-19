namespace DesignPatternUsage.Abstractions;

/// <summary>
/// Contract for discount rule.
/// </summary>
public interface IDiscountRule
{
    /// <summary>
    /// Returns discounted price based on conditions
    /// </summary>
    /// <param name="currentItem">Item on which discount has been applied</param>
    /// <param name="purchasedItems">Other items in cart.</param>
    /// <returns>Price of the item</returns>
    public decimal GetDiscountPrice(Item currentItem, List<Item> purchasedItems);
}
