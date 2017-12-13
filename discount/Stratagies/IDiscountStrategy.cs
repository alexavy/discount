namespace Discount
{
    public interface IDiscountStrategy
    {
        decimal? ApplyDiscount(CalculatorArgs args);
    }
}
