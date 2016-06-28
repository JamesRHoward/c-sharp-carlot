using System.Collections.Generic;

namespace Dealership.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _mileage;
    private int _price;
    private static List<Car> _instances = new List<Car> {};

    public Car (string makeModel, int mileage, int price) {
      _makeModel = makeModel;
      _mileage = mileage;
      _price = price;
      _instances.Add(this);
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public string GetMake()
    {
      return _makeModel;
    }
    public int GetMileage()
    {
      return _mileage;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void SetMake(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public void SetMileage(int newMileage)
    {
      _mileage = newMileage;
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
  }
  // public class CarLot
  // {
  //
  // }
}
