namespace csharp.CategorizedItems
{
    public static class ItemExtensions
    {
        public static bool IsExpiredSale(this Item item)
        {
            return item.SellIn <= 0;
        }

        public static void QualityDropsToZero(this Item item)
        {
            item.Quality = 0;
        }

        public static void QualityIncrement(this Item item, int rate = 1)
        {
            for (var i = 0; i < rate; i++)
            {
                if (item.Quality < 50)
                    item.Quality += 1;
            }
        }

        public static void QualityDecrement(this Item item, int rate = 1)
        {
            for (var i = 0; i < rate; i++)
            {
                if (item.Quality > 0)
                    item.Quality -= 1;
            }
        }

        public static void SellInDecrement(this Item item)
        {
            item.SellIn -= 1;
        }
    }
}