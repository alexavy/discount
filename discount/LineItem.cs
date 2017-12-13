namespace Discount
{
    public class LineItem
    {
        public DiscountMethod DiscountMethod { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public bool IsStock { get; set; }
    }
}
