namespace csharp.ItemUpdater
{
    public static class ItemExtensions
    {
        public static bool IsExpiredSale(this Item item)
        {
            return item.SellIn < 0;
        }

        public static void QualityDropsToZero(this Item item)
        {
            item.Quality = 0;
        }
        
        public static void QualityIncrement(this Item item)
        {
            if (item.Quality < 50)
                item.Quality += 1;
        }

        public static void QualityDecrement(this Item item)
        {
            if (item.Quality > 0)
                item.Quality -= 1;
        }

        public static void SellInDecrement(this Item item)
        {
            item.SellIn -= 1;
        }
    }
}