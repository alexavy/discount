using System.Linq;

namespace Discount
{
    public class BrandGroupDiscountStrategy : IDiscountStrategy
    {
        public decimal? ApplyDiscount(CalculatorArgs args)
        {
            return !string.IsNullOrEmpty(args.Brand)
                ? args.Lines.Where(x => x.Name == args.Brand).Sum(x => x.Cost) * args.Discount
                : args.Lines.Sum(x => x.Cost);
        }
    }
}
