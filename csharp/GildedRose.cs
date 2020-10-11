using System.Collections.Generic;
using csharp.CategorizedItems;

namespace csharp
{
    public class GildedRose
    {
        public readonly IList<Item> Items;

        public GildedRose(IList<Item> items)
        {
            Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                UpdateItem(item);
            }
        }

        private static void UpdateItem(Item item)
        {
            var categorizedItem = CategorizedItemFactory.Create(item);
            categorizedItem.Update();
        }
    }
}