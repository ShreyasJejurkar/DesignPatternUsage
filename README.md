# DesignPatternUsage


Virtual Basket

Please implement C# code that calculates the total price of a given collection of items. The solution should support applying discount rules.

Specifically, a “buy two, get one free” deal for certain items or combinations of certain items must be implemented

For example, if a “buy two, get one free” promotion is enabled for apples, when buying 3 apples and 3 oranges, payment for 2 apples and 3 oranges would be required

## Approch 
1. I created `IPriceCalculator` and `PriceCalculator` classes and created a method based on the API description provided in the problem. 
2. Then I read about discounts in the problem statement, they say we should be able to create new discounts easily without changing much code. This indicates we should have common abstractions for discounts so then I created the `IDiscountRule` interface and added the `GetDiscountPrice` method. 
2. In the `GetDiscountPrice` method in `IDiscount`, I took 2 parameters, first one is the item on which discount is applied and the other items in the cart. As sometimes discount can be applied in case condition is on other items of the cart as well. For ex - Buy items A and B and get item C to achieve this we need a cart as well while calculating discounts. 
3. Then I added the Item class with basic properties and added a method `GetFinalPriceAfterDiscount` so that this method will iterate over all discount for a given item and returns a new price for it. If there is no discount for the current given item, then the actual price will be considered. 
4. `IDiscountRule` is an important abstraction here, because that way we can add a new discount implementation without changing the `GetFinalPriceAfterDiscount` method in the item. 
