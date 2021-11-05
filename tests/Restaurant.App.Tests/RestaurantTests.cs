using Xunit;

namespace Restaurant.App.Tests;

public class RestaurantTests
{

    [Theory]
    [InlineData(8, 16, 10)]
    [InlineData(11, 23, 18)]
    [InlineData(12, 20, 14)]
    public void IsOpen_WhenHourIsInInRange_ReturnsTrue(int from, int to, int input)
    {
        Restaurant restaurant = new()
        {
            RestaurantId = 1,
            PhoneNumber = "+100000",
            Address = "USA",
            EnglishName = "KFC",
            PersianName = "کی اف سی",
            OpeningHours = (From: from, To: to),
        };

        bool isOpen = restaurant.IsOpen(input);

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
