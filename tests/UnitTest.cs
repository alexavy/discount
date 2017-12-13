using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Discount;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        private CalculatorArgs _calculatorArgs;

        [TestInitialize]
        public void ClassInitialize()
        {
            _calculatorArgs = new CalculatorArgs
            {
                Lines = new[]
                 {
                    new LineItem { Id = 1, Name = "Nokia", Cost = 1000, IsStock = true },
                    new LineItem { Id = 2, Name = "Nokia", Cost = 500, IsStock = false },
                    new LineItem { Id = 3, Cost = 2500, IsStock = true }
                }
            };
        }

        [TestMethod]
        public void Check_The_Price_Didnot_Change()
        {
            _calculatorArgs.Brand = null;

            var strategy = new BrandGroupDiscountStrategy();
            var discountCalculatorService = new DiscountCalculatorService(strategy);
            var finalPrice = discountCalculatorService.ApplyDiscountMethod(_calculatorArgs);
            Assert.AreEqual(4000, finalPrice);
        }

        [TestMethod]
        public void When_Apply_Brand_Group_Discount_The_Cost_Is_5_Percent_Lest()
        {
            _calculatorArgs.Brand = "Nokia";
            _calculatorArgs.Discount = 0.95m;

            var strategy = new BrandGroupDiscountStrategy();
            var discountCalculatorService = new DiscountCalculatorService(strategy);
            var finalPrice = discountCalculatorService.ApplyDiscountMethod(_calculatorArgs);
            Assert.AreEqual(1425, finalPrice);
        }

        [TestMethod]
        public void When_Apply_Coupon_Discount_And_Amount_From_3000_The_Cost_Is_1000_Lest()
        {
            _calculatorArgs.DiscountSum = 1000;

            var strategy = new CouponDiscountStrategy();
            var discountCalculatorService = new DiscountCalculatorService(strategy);
            var finalPrice = discountCalculatorService.ApplyDiscountMethod(_calculatorArgs);
            Assert.AreEqual(3000, finalPrice);
        }

        [TestMethod]
        public void When_Apply_InStock_Group_Discount_The_Cost_Is_10_Percent_Lest()
        {
            _calculatorArgs.Discount = 0.90m;

            var strategy = new InStockDiscountStrategy();
            var discountCalculatorService = new DiscountCalculatorService(strategy);
            var finalPrice = discountCalculatorService.ApplyDiscountMethod(_calculatorArgs);
            Assert.AreEqual(3150, finalPrice);
        }
    }
}
