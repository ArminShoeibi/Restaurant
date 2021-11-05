using Xunit;

namespace Restaurant.App.Tests;

public class RestaurantTests
{

    [Fact]
    public void IsOpen_WhenHourIsInInRange_ReturnsTrue()
    {
        Restaurant restaurant = new()
        {
            RestaurantId = 1,
            PhoneNumber = "+100000",
            Address = "USA",
            EnglishName = "KFC",
            PersianName = "کی اف سی",
            OpeningHours = (From: 10, To: 22),
        };

        bool isOpen = restaurant.IsOpen(12);

        Assert.True(isOpen);
    }

    [Fact]
    public void IsOpen_WhenHourIsntInRange_ReturnsFalse()
    {
        Restaurant restaurant = new()
        {
            RestaurantId = 1,
            PhoneNumber = "+100000",
            Address = "USA",
            EnglishName = "KFC",
            PersianName = "کی اف سی",
            OpeningHours = (From: 10, To: 22),
        };

        bool isOpen = restaurant.IsOpen(23);
        Assert.False(isOpen);
    }

}
