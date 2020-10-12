using System;
using System.Collections.Generic;
using csharp;
using Xunit;

namespace XUnitTestProject
{
    public class GildedRoseTest
    {
        public class NormalなItemの場合
        {
            [Fact]
            public void UpdateQualityを実行してもItem名は変わらない()
            {
                // Arrange
                var items = new List<Item> {new Item {Name = "Normal", Quality = 10, SellIn = 10}};
                var gildedRose = new GildedRose(items);

                // Act
                gildedRose.UpdateQuality();

                // Assert
                Assert.Equal("Normal", gildedRose.Items[0].Name);
            }

            [Fact]
            public void UpdateQualityを実行するとSellInが1減る()
            {
                var items = new List<Item> {new Item {Name = "Normal", Quality = 10, SellIn = 10}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(9, gildedRose.Items[0].SellIn);
            }

            [Fact]
            public void UpdateQualityを実行するとQualityが1減る()
            {
                var items = new List<Item> {new Item {Name = "Normal", Quality = 10, SellIn = 10}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(9, gildedRose.Items[0].Quality);
            }

            [Fact]
            public void SellInが0日以下の場合にUpdateQualityを実行するとQualityが2減る()
            {
                var items = new List<Item> {new Item {Name = "Normal", Quality = 10, SellIn = 0}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(8, gildedRose.Items[0].Quality);
            }

            [Fact]
            public void SellInが0日以下でQualityが1の場合にUpdateQualityを実行してもQualityが0より小さくならない()
            {
                var items = new List<Item> {new Item {Name = "Normal", Quality = 1, SellIn = 0}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(0, gildedRose.Items[0].Quality);
            }

            [Fact]
            public void Qualityが0の場合にUpdateQualityを実行してもQualityが0より小さくならない()
            {
                var items = new List<Item> {new Item {Name = "Normal", Quality = 0, SellIn = 10}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(0, gildedRose.Items[0].Quality);
            }
        }

        public class AgedBrieなItemの場合
        {
            [Fact]
            public void UpdateQualityを実行してもItem名は変わらない()
            {
                var items = new List<Item> {new Item {Name = "Aged Brie", Quality = 10, SellIn = 10}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal("Aged Brie", gildedRose.Items[0].Name);
            }

            [Fact]
            public void UpdateQualityを実行するとSellInが1減る()
            {
                var items = new List<Item> {new Item {Name = "Aged Brie", Quality = 10, SellIn = 10}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(9, gildedRose.Items[0].SellIn);
            }

            [Fact]
            public void SellInが0日より大きい場合にUpdateQualityを実行するとQualityが1増える()
            {
                var items = new List<Item> {new Item {Name = "Aged Brie", Quality = 10, SellIn = 1}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(11, gildedRose.Items[0].Quality);
            }

            [Fact]
            public void SellInが0日以下の場合にUpdateQualityを実行するとQualityが2増える()
            {
                var items = new List<Item> {new Item {Name = "Aged Brie", Quality = 10, SellIn = 0}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(12, gildedRose.Items[0].Quality);
            }

            [Fact]
            public void UpdateQualityを実行してもQualityが50より増えない()
            {
                var items = new List<Item> {new Item {Name = "Aged Brie", Quality = 50, SellIn = 10}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(50, gildedRose.Items[0].Quality);
            }

            [Fact]
            public void SellInが0日以下の場合にUpdateQualityを実行してもQualityが50より増えない()
            {
                var items = new List<Item> {new Item {Name = "Aged Brie", Quality = 50, SellIn = 0}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(50, gildedRose.Items[0].Quality);
            }
        }

        public class BackstagePassesなItemの場合
        {
            [Fact]
            public void UpdateQualityを実行してもItem名は変わらない()
            {
                var items = new List<Item>
                    {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 10}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal("Backstage passes to a TAFKAL80ETC concert", gildedRose.Items[0].Name);
            }

            [Fact]
            public void UpdateQualityを実行するとSellInが1減る()
            {
                var items = new List<Item>
                    {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 10}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(9, gildedRose.Items[0].SellIn);
            }

            [Fact]
            public void SellInが10日より多い場合にUpdateQualityを実行するとQualityが1増える_境界値_SellInが11()
            {
                var items = new List<Item>
                    {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 11}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(11, gildedRose.Items[0].Quality);
            }

            [Fact]
            public void SellInが10日以内かつ5日より多い場合にUpdateQualityを実行するとQualityが2増える_境界値_SellInが10()
            {
                var items = new List<Item>
                    {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 10}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(12, gildedRose.Items[0].Quality);
            }

            [Fact]
            public void SellInが10日以内かつ5日より多い場合にUpdateQualityを実行するとQualityが2増える_境界値_SellInが6()
            {
                var items = new List<Item>
                    {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 6}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(12, gildedRose.Items[0].Quality);
            }

            [Fact]
            public void SellInが5日以内の場合にUpdateQualityを実行するとQualityが3増える_境界値_SellInが5()
            {
                var items = new List<Item>
                    {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 5}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(13, gildedRose.Items[0].Quality);
            }
        }

        public class SulfurasなItemの場合
        {
            private readonly List<Item> _items;

            public SulfurasなItemの場合()
            {
                _items = new List<Item> {new Item {Name = "Sulfuras, Hand of Ragnaros", Quality = 49, SellIn = 10}};
            }

            [Fact]
            public void UpdateQualityを実行してもItem名は変わらない()
            {
                var gildedRose = new GildedRose(_items);
                gildedRose.UpdateQuality();
                Assert.Equal("Sulfuras, Hand of Ragnaros", gildedRose.Items[0].Name);
            }

            [Fact]
            public void UpdateQualityを実行してもSellInは変わらない()
            {
                var gildedRose = new GildedRose(_items);
                gildedRose.UpdateQuality();
                Assert.Equal(10, gildedRose.Items[0].SellIn);
            }

            [Fact]
            public void UpdateQualityを実行してもQualityは変わらない()
            {
                var gildedRose = new GildedRose(_items);
                gildedRose.UpdateQuality();
                Assert.Equal(49, gildedRose.Items[0].Quality);
            }
        }

        public class ConjuredなItemの場合
        {
            [Fact]
            public void UpdateQualityを実行してもItem名は変わらない()
            {
                var items = new List<Item> {new Item {Name = "Conjured", Quality = 10, SellIn = 10}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal("Conjured", gildedRose.Items[0].Name);
            }

            [Fact]
            public void UpdateQualityを実行するとSellInが1減る()
            {
                var items = new List<Item> {new Item {Name = "Conjured", Quality = 10, SellIn = 10}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(9, gildedRose.Items[0].SellIn);
            }

            [Fact]
            public void SellInが0日より多い場合にUpdateQualityを実行するとQualityが2減る()
            {
                var items = new List<Item> {new Item {Name = "Conjured", Quality = 10, SellIn = 10}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(8, gildedRose.Items[0].Quality);
            }

            [Fact]
            public void SellInが0日以下の場合にUpdateQualityを実行するとQualityが4減る()
            {
                var items = new List<Item> {new Item {Name = "Conjured", Quality = 10, SellIn = 0}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(6, gildedRose.Items[0].Quality);
            }

            [Fact]
            public void SellInが0日以下でQualityが3以下の場合にUpdateQualityを実行してもQualityが0より小さくならない()
            {
                var items = new List<Item> {new Item {Name = "Conjured", Quality = 3, SellIn = 0}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(0, gildedRose.Items[0].Quality);
            }

            [Fact]
            public void Qualityが1以下の場合にUpdateQualityを実行してもQualityより小さくならない()
            {
                var items = new List<Item> {new Item {Name = "Conjured", Quality = 1, SellIn = 10}};
                var gildedRose = new GildedRose(items);
                gildedRose.UpdateQuality();
                Assert.Equal(0, gildedRose.Items[0].Quality);
            }
        }
    }
}