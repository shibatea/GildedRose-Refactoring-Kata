namespace csharp.CategorizedItems
{
    public class AgedBrieItem : AbstractCategorizedItem
    {
        public AgedBrieItem(Item item) : base(item)
        {
        }

        protected override void UpdateSellIn()
        {
            Item.SellInDecrement();
        }

        protected override void UpdateQuality()
        {
            if (Item.IsExpiredSale())
            {
                Item.QualityIncrement();
                Item.QualityIncrement();
            }
            else
            {
                Item.QualityIncrement();
            }
        }
    }
}