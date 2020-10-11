using System;
using System.Collections.Generic;
using csharp;
using Xunit;

namespace XUnitTestProject
{
    public class GildedRoseTest
    {
        public class ItemがNormalの場合
        {
            [Fact]
            public void SellInが0日より多い場合はItemのQualityが1減る()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Normal",
                        Quality = 10,
                        SellIn = 10
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Normal", actualItem.Name);
                Assert.Equal(9, actualItem.Quality);
                Assert.Equal(9, actualItem.SellIn);
            }

            [Fact]
            public void SellInが0日以下の場合はItemのQualityが2減る()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Normal",
                        Quality = 10,
                        SellIn = 0
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Normal", actualItem.Name);
                Assert.Equal(8, actualItem.Quality);
                Assert.Equal(-1, actualItem.SellIn);
            }

            [Fact]
            public void SellInが0日以下でQualityが1の場合はItemのQualityが1減る()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Normal",
                        Quality = 1,
                        SellIn = 0
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Normal", actualItem.Name);
                Assert.Equal(0, actualItem.Quality);
                Assert.Equal(-1, actualItem.SellIn);
            }

            [Fact]
            public void Qualityが0の場合ItemのQualityは変わらない()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Normal",
                        Quality = 0,
                        SellIn = 10
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Normal", actualItem.Name);
                Assert.Equal(0, actualItem.Quality);
                Assert.Equal(9, actualItem.SellIn);
            }
        }

        public class ItemNameがAgedBrieの場合
        {
            [Fact]
            public void SellInが0日より大きい場合はItemのQualityが1増える()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Aged Brie",
                        Quality = 10,
                        SellIn = 10
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Aged Brie", actualItem.Name);
                Assert.Equal(11, actualItem.Quality);
                Assert.Equal(9, actualItem.SellIn);
            }

            [Fact]
            public void SellInが0日以下の場合はItemのQualityが2増える()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Aged Brie",
                        Quality = 10,
                        SellIn = 0
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Aged Brie", actualItem.Name);
                Assert.Equal(12, actualItem.Quality);
                Assert.Equal(-1, actualItem.SellIn);
            }
        }

        public class ItemNameがBackstagePassesの場合
        {
            [Fact]
            public void SellInが10日より多い場合はItemのQualityが1増える()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        Quality = 10,
                        SellIn = 11
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Backstage passes to a TAFKAL80ETC concert", actualItem.Name);
                Assert.Equal(11, actualItem.Quality);
                Assert.Equal(10, actualItem.SellIn);
            }

            [Fact]
            public void SellInが10日以内の場合はItemのQualityが2増える()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        Quality = 10,
                        SellIn = 10
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Backstage passes to a TAFKAL80ETC concert", actualItem.Name);
                Assert.Equal(12, actualItem.Quality);
                Assert.Equal(9, actualItem.SellIn);
            }

            [Fact]
            public void SellInが5日より多い場合はItemのQualityが2増える()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        Quality = 10,
                        SellIn = 6
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Backstage passes to a TAFKAL80ETC concert", actualItem.Name);
                Assert.Equal(12, actualItem.Quality);
                Assert.Equal(5, actualItem.SellIn);
            }

            [Fact]
            public void SellInが5日以内の場合はItemのQualityが3増える()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        Quality = 10,
                        SellIn = 5
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Backstage passes to a TAFKAL80ETC concert", actualItem.Name);
                Assert.Equal(13, actualItem.Quality);
                Assert.Equal(4, actualItem.SellIn);
            }
        }

        public class ItemNameがSulfurasの場合
        {
            [Fact]
            public void Itemの値は変わらない()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Sulfuras, Hand of Ragnaros",
                        Quality = 49,
                        SellIn = 10
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Sulfuras, Hand of Ragnaros", actualItem.Name);
                Assert.Equal(49, actualItem.Quality);
                Assert.Equal(10, actualItem.SellIn);
            }
        }

        public class ItemがConjuredの場合
        {
            [Fact]
            public void SellInが0日より多い場合はItemのQualityが2減る()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Conjured",
                        Quality = 10,
                        SellIn = 10
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Conjured", actualItem.Name);
                Assert.Equal(8, actualItem.Quality);
                Assert.Equal(9, actualItem.SellIn);
            }

            [Fact]
            public void SellInが0日以下の場合はItemのQualityが4減る()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Conjured",
                        Quality = 10,
                        SellIn = 0
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Conjured", actualItem.Name);
                Assert.Equal(6, actualItem.Quality);
                Assert.Equal(-1, actualItem.SellIn);
            }

            [Fact]
            public void SellInが0日以下でQualityが1の場合はItemのQualityが1減る()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Conjured",
                        Quality = 1,
                        SellIn = 0
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Conjured", actualItem.Name);
                Assert.Equal(0, actualItem.Quality);
                Assert.Equal(-1, actualItem.SellIn);
            }

            [Fact]
            public void Qualityが0の場合ItemのQualityは変わらない()
            {
                // Arrange
                var gildedRose = new GildedRose(new List<Item>
                {
                    new Item
                    {
                        Name = "Conjured",
                        Quality = 0,
                        SellIn = 10
                    }
                });

                // Act
                gildedRose.UpdateQuality();

                // Assert
                var actualItem = gildedRose.Items[0];
                Assert.Equal("Conjured", actualItem.Name);
                Assert.Equal(0, actualItem.Quality);
                Assert.Equal(9, actualItem.SellIn);
            }
        }
    }
}