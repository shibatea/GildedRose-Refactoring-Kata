namespace csharp.CategorizedItems
{
    public abstract class AbstractCategorizedItem : ICategorizedItem
    {
        protected AbstractCategorizedItem(Item item)
        {
            Item = item;
        }

        protected Item Item { get; }

        public void Update()
        {
            UpdateSellIn();
            UpdateQuality();
        }

        protected abstract void UpdateSellIn();

        protected abstract void UpdateQuality();
    }
}