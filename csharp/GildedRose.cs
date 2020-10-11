﻿using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        const string agedBrie = "Aged Brie";
        const string backstagePasses = "Backstage passes to a TAFKAL80ETC concert";
        const string sulfuras = "Sulfuras, Hand of Ragnaros";

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
            if (IsSulfurasItem(item)) return;

            if (IsAgedBrieItem(item))
            {
                if (item.Quality < 50)
                {
                    ItemQualityIncrement(item);
                }
            }
            else
            {
                if (IsBackstagePassesItem(item))
                {
                    if (item.Quality < 50)
                    {
                        ItemQualityIncrement(item);

                        if (IsBackstagePassesItem(item))
                        {
                            if (item.SellIn < 11)
                            {
                                if (item.Quality < 50)
                                {
                                    ItemQualityIncrement(item);
                                }
                            }

                            if (item.SellIn < 6)
                            {
                                if (item.Quality < 50)
                                {
                                    ItemQualityIncrement(item);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (item.Quality > 0)
                    {
                        ItemQualityDecrement(item);
                    }
                }
            }

            item.SellIn -= 1;

            if (item.SellIn >= 0) return;

            if (IsAgedBrieItem(item))
            {
                if (item.Quality < 50)
                {
                    ItemQualityIncrement(item);
                }
            }
            else
            {
                if (IsBackstagePassesItem(item))
                {
                    item.Quality -= item.Quality;
                }
                else
                {
                    if (item.Quality <= 0) return;

                    ItemQualityDecrement(item);
                }
            }
        }

        private static void ItemQualityIncrement(Item item)
        {
            item.Quality += 1;
        }

        private static void ItemQualityDecrement(Item item)
        {
            item.Quality -= 1;
        }

        private static bool IsSulfurasItem(Item item)
        {
            return item.Name == sulfuras;
        }

        private static bool IsBackstagePassesItem(Item item)
        {
            return item.Name == backstagePasses;
        }

        private static bool IsAgedBrieItem(Item item)
        {
            return item.Name == agedBrie;
        }
    }
}