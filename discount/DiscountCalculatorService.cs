namespace Discount
{
    public class DiscountCalculatorService
    {
        private readonly IDiscountStrategy _discountStrategy;

        public DiscountCalculatorService(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal? ApplyDiscountMethod(CalculatorArgs args)
        {
            return _discountStrategy.ApplyDiscount(args);
        }
    }
}
