namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order>{};
    public string Title {get; set;}
    public string Description {get; set;}
    public string Price {get; set;}
    public string Date {get; set;}
    public int Id {get;}

    public Order(string title, string description, string price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}