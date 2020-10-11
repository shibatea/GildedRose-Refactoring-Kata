namespace csharp.CategorizedItems
{
    public class NormalItem : AbstractCategorizedItem
    {
        public NormalItem(Item item) : base(item)
        {
        }

        protected override void UpdateQuality()
        {
            if (Item.IsExpiredSale())
            {
                Item.QualityDecrement(ExpiredSaleRate);
            }
            else
            {
                Item.QualityDecrement();
            }
        }

        protected override void UpdateSellIn()
        {
            Item.SellInDecrement();
        }
    }
}