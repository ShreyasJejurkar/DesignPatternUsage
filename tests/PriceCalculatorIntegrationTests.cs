using DesignPatternUsage.Discounts;
using System.Collections.Generic;
using Xunit;
namespace DesignPatternUsage.Tests;

public class PriceCalculatorIntegrationTests
{
    [Fact]
    public void ReturnsCorrectTotal_WhenItemsAddedWithoutDiscount()
    {
        var cartItems = new List<Item>()
        {
            new Item("Product 1", 100, 3),
            new Item("Product 2", 100),
            new Item("Product 3", 100, 3)
        };

        PriceCalculator priceCalculator = new();
        var price = priceCalculator.CalculatePrice(cartItems);

        Assert.Equal(700, price);
    }

    [Fact]
    public void WhenB2G1Added_CartAddsExtraItem_WithoutIncreaseInPrice()
    {
        var cartItems = new List<Item>()
        {
            new Item("Product 1", 100, 3),
            new Item("Product 2", 100),
            new Item("Product 3", 100, 3)
        };

        cartItems[0].Discounts.Add(new BuyTwoGetOneFreeDiscountRule());
        cartItems[2].Discounts.Add(new FakeDiscount());

        PriceCalculator priceCalculator = new();
        _ = priceCalculator.CalculatePrice(cartItems);

        Assert.Equal(4, cartItems[0].Quantity);
    }
}
