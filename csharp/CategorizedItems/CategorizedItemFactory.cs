namespace csharp.CategorizedItems
{
    public static class CategorizedItemFactory
    {
        private const string AgedBrie = "Aged Brie";
        private const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
        private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        private const string Conjured = "Conjured";

        public static ICategorizedItem Create(Item item)
        {
            if (IsSulfurasItem(item))
                return new SulfurasItem(item);
            if (IsBackstagePassesItem(item))
                return new BackstagePassesItem(item);
            if (IsAgedBrieItem(item))
                return new AgedBrieItem(item);
            if(IsConjuredItem(item))
                return new ConjuredItem(item);
            return new NormalItem(item);
        }

        private static bool IsSulfurasItem(Item item)
        {
            return item.Name == Sulfuras;
        }

        private static bool IsBackstagePassesItem(Item item)
        {
            return item.Name == BackstagePasses;
        }

        private static bool IsAgedBrieItem(Item item)
        {
            return item.Name == AgedBrie;
        }
        
        private static bool IsConjuredItem(Item item)
        {
            return item.Name == Conjured;
        }
    }
}