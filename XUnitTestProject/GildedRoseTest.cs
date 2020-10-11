using System;
using System.Collections.Generic;
using csharp;
using Xunit;

namespace XUnitTestProject
{
    public class GildedRoseTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var gildedRose = new GildedRose(new List<Item>
            {
                new Item
                {
                    Name = "hoge",
                    Quality = 30,
                    SellIn = 10
                }
            });

            // Act
            gildedRose.UpdateQuality();

            // Assert
            var actualItem = gildedRose.Items[0];
            Assert.Equal("hoge", actualItem.Name);
            Assert.Equal(29,actualItem.Quality);
            Assert.Equal(9,actualItem.SellIn);
        }
    }
}