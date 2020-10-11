namespace csharp.CategorizedItems
{
    public class ConjuredItem : AbstractCategorizedItem
    {
        public ConjuredItem(Item item) : base(item)
        {
        }

        protected override void UpdateSellIn()
        {
            Item.SellInDecrement();
        }

        protected override void UpdateQuality()
        {
            const int qualityDegradationRate = 2;

            if (Item.IsExpiredSale())
            {
                Item.QualityDecrement(ExpiredSaleRate * qualityDegradationRate);
            }
            else
            {
                Item.QualityDecrement(qualityDegradationRate);
            }
        }
    }
}