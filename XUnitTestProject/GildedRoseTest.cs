using System;
using System.Collections.Generic;
using csharp;
using Xunit;

namespace XUnitTestProject
{
    public class GildedRoseTest
    {
        [Fact]
        public void ItemNameÇ™HogeÇÃèÍçá()
        {
            // Arrange
            var gildedRose = new GildedRose(new List<Item>
            {
                new Item
                {
                    Name = "hoge",
                    Quality = 0,
                    SellIn = 0
                }
            });

            // Act
            gildedRose.UpdateQuality();

            // Assert
            var actualItem = gildedRose.Items[0];
            Assert.Equal("hoge", actualItem.Name);
            Assert.Equal(0,actualItem.Quality);
            Assert.Equal(-1,actualItem.SellIn);
        }

        [Fact]
        public void ItemNameÇ™AgedBrieÇÃèÍçá()
        {
            // Arrange
            var gildedRose = new GildedRose(new List<Item>
            {
                new Item
                {
                    Name = "Aged Brie",
                    Quality = 0,
                    SellIn = 0
                }
            });

            // Act
            gildedRose.UpdateQuality();

            // Assert
            var actualItem = gildedRose.Items[0];
            Assert.Equal("Aged Brie", actualItem.Name);
            Assert.Equal(2, actualItem.Quality);
            Assert.Equal(-1, actualItem.SellIn);
        }

        [Fact]
        public void ItemNameÇ™BackstagePassesÇÃèÍçá()
        {
            // Arrange
            var gildedRose = new GildedRose(new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    Quality = 0,
                    SellIn = 0
                }
            });

            // Act
            gildedRose.UpdateQuality();

            // Assert
            var actualItem = gildedRose.Items[0];
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", actualItem.Name);
            Assert.Equal(0, actualItem.Quality);
            Assert.Equal(-1, actualItem.SellIn);
        }

        [Fact]
        public void ItemNameÇ™SulfurasÇÃèÍçá()
        {
            // Arrange
            var gildedRose = new GildedRose(new List<Item>
            {
                new Item
                {
                    Name = "Sulfuras, Hand of Ragnaros",
                    Quality = 0,
                    SellIn = 0
                }
            });

            // Act
            gildedRose.UpdateQuality();

            // Assert
            var actualItem = gildedRose.Items[0];
            Assert.Equal("Sulfuras, Hand of Ragnaros", actualItem.Name);
            Assert.Equal(0, actualItem.Quality);
            Assert.Equal(0, actualItem.SellIn);
        }
    }
}