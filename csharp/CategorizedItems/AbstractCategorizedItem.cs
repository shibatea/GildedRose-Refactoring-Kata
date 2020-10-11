namespace csharp.CategorizedItems
{
    public abstract class AbstractCategorizedItem : ICategorizedItem
    {
        protected const int ExpiredSaleRate = 2;

        protected AbstractCategorizedItem(Item item)
        {
            Item = item;
        }

        protected Item Item { get; }

        public void Update()
        {
            UpdateQuality();
            UpdateSellIn();
        }

        protected abstract void UpdateSellIn();

        protected abstract void UpdateQuality();
    }
}