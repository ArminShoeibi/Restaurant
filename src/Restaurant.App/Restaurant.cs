namespace Restaurant.App;

public class Restaurant
{
    public int RestaurantId { get; set; }
    public string EnglishName { get; set; }
    public string PersianName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public (int From, int To) OpeningHours { get; set; }

    public bool IsOpen(int hour)
    {
        (int from, int to) = OpeningHours;
        if (hour >= from && hour <= to) return true;
        return false;
    }
}
