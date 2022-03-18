public interface IDiscountRule
{
    decimal ApplyRule(List<Item> purchasedItems);
}
