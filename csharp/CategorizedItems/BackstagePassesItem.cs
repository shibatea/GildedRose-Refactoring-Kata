namespace csharp.CategorizedItems
{
    public class BackstagePassesItem : AbstractCategorizedItem
    {
        public BackstagePassesItem(Item item) : base(item)
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
                Item.QualityDropsToZero();
            }
            else
            {
                Item.QualityIncrement();
                if (Item.SellIn <= 10) Item.QualityIncrement();
                if (Item.SellIn <= 5) Item.QualityIncrement();
            }
        }
    }
}