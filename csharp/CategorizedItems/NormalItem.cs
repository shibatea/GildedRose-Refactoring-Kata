namespace csharp.CategorizedItems
{
    public class NormalItem : AbstractCategorizedItem
    {
        public NormalItem(Item item) : base(item)
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
                Item.QualityDecrement();
                Item.QualityDecrement();
            }
            else
            {
                Item.QualityDecrement();
            }
        }
    }
}