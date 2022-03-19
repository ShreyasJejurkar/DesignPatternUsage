namespace DesignPatternUsage.Abstractions;

/// <summary>
/// Abstraction for price calculator.
/// </summary>
public interface IPriceCalculator
{
    /// <summary>
    /// Returns price for purchased items
    /// </summary>
    /// <param name="purchasedItems"></param>
    /// <returns>Price for checkout</returns>
    decimal CalculatePrice(List<Item> purchasedItems);
}
