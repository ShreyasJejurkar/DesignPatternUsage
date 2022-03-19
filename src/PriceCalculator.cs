using DesignPatternUsage.Abstractions;

namespace DesignPatternUsage;

/// <summary>
/// Class resposible for calculating price of items
/// </summary>
public class PriceCalculator : IPriceCalculator
{
    /// <summary>
    /// Calculate the purchased items price.
    /// </summary>
    /// <param name="purchasedItems">Purchased items</param>
    /// <returns>Checkout amount</returns>
    public decimal CalculatePrice(List<Item> purchasedItems)
    {
        var totalAmount = 0m;

        foreach (var item in purchasedItems)
        {
            totalAmount += item.GetFinalPriceAfterDiscount(purchasedItems);
        }

        return totalAmount;
    }
}
