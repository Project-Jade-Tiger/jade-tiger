using Jade.Tiger.Domain.Tests;

namespace Jade.Tiger.Domain.Tests;

[TestClass]
public class ItemTests
{
    [TestMethod]
    public void Can_Create_New_Item()
    {
        var name = "Test Item";
        var description = "Test Description";
        var brand = "Test Brand";
        var price = 10.99m;
        // Act
        var item = new Item (name, description, brand, price);
        // Assert
        Assert.AreEqual(name, item.Name);
        Assert.AreEqual(description, item. Description);
        Assert.AreEqual(brand, item. Brand);
        Assert.AreEqual(price, item. Price);
    }
}

    ﻿

    [TestMethod]
    public void Can_Add_Rating_To_Item()
    {
    // Arrange
    var name = "Test Item";
    var description = "Test Description";
    var brand = "Test Brand";
    var price = 10.99m;
    
    var starRating = 4;
    var userName = "Test User";
    var review = "Test Review";
    
    // Act
    var item = new Item(name, description, brand, price); var rating = new Rating (starRating, userName, review); item.AddRating (rating);
    var rating = new Rating(starRating, userName, review);
    item.AddRating(rating);
    
    // Assert
    Assert.AreEqual(rating, item.Ratings.First());
    }
