namespace csharp.CategorizedItems
{
    public class AgedBrieItem : AbstractCategorizedItem
    {
        public AgedBrieItem(Item item) : base(item)
        {
        }

        protected override void UpdateQuality()
        {
            if (Item.IsExpiredSale())
            {
                Item.QualityIncrement(ExpiredSaleRate);
            }
            else
            {
                Item.QualityIncrement();
            }
        }

        protected override void UpdateSellIn()
        {
            Item.SellInDecrement();
        }
    }
}