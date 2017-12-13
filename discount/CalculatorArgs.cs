using System;
using System.Collections.Generic;

namespace Discount
{
    public class CalculatorArgs
    {
        public IEnumerable<LineItem> Lines;
        public string Brand;
        public decimal Discount;
        public decimal DiscountSum;
    }
}
