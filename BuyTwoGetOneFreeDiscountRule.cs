namespace DesignPatternUsage;

public class BuyTwoGetOneFreeDiscountRule : IDiscountRule
{
    public decimal GetDiscountPrice(Item currentItem, List<Item> purchasedItems)
    {
        decimal price;

        // If there are exactly 2 items, then add item
        if (currentItem.Quantity == 2)
        {
            price = currentItem.Quantity * currentItem.ActualPrice;

            currentItem.Quantity += 1;
        }

        // If there are more than 2 items and there can be items in multiples of 2. 
        // Let's say user purchased 4 items, then as per discount rule, we need to 2 more
        // items to the user. 
        else if (currentItem.Quantity > 2)
        {
            price = currentItem.Quantity * currentItem.ActualPrice;

            var modValue = currentItem.Quantity % 2;

            if (modValue == 0)
            {
                var doubleQuantityCount =  currentItem.Quantity / 2;

                currentItem.Quantity += doubleQuantityCount;
            }
            else
            {
                var oneMinus = currentItem.Quantity - 1;

                if (oneMinus % 2 == 0)
                {
                    var doubleQuantityCount = oneMinus / 2;

                    currentItem.Quantity += doubleQuantityCount;
                }
            }
        }

        // otherwise no
        else
        {
            price = currentItem.Quantity * currentItem.ActualPrice;
        }

        return price;
    }
}
