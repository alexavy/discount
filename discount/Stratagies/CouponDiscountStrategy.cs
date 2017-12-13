using System.Linq;

namespace Discount
{
    public class CouponDiscountStrategy : IDiscountStrategy
    {
        public decimal? ApplyDiscount(CalculatorArgs args)
        {
            var totalCost = args.Lines.Sum(x => x.Cost);
            return totalCost >= 3000 ? totalCost - args.DiscountSum : totalCost;
        }
    }
}
