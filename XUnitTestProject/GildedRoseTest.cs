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
    }
}