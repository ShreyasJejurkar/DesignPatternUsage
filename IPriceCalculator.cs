public interface IPriceCalculator
{
    decimal CalculatePrice(List<Item> purchasedItems);
}


public class PriceCalculator : IPriceCalculator
{
    public decimal CalculatePrice(List<Item> purchasedItems)
    {
        var totalAmount = 0m;

        foreach(var item in purchasedItems) 
        {
            totalAmount += item.GetFinalPriceAfterDiscount(purchasedItems);
        }

        return totalAmount;
    }
}