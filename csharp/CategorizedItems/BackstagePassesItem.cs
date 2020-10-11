using System;

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
                if (Item.SellIn <= 5) Item.QualityIncrement(3);
                else if (Item.SellIn <= 10) Item.QualityIncrement(2);
                else if (Item.SellIn > 10) Item.QualityIncrement();
            }
        }
    }
}