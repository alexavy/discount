using System.Linq;

namespace Discount
{
    public class InStockDiscountStrategy : IDiscountStrategy
    {
        public decimal? ApplyDiscount(CalculatorArgs args)
        {
            return args.Lines.Where(x => x.IsStock).Sum(x => x.Cost) * args.Discount;
        }
    }
}
