using Nancy;
using Dealership.Objects;
using System.Collections.Generic;

namespace Dealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_car.cshtml"];
      Get["view_cars"] = _ => {
        List<Car> allCars = Car.GetAll();
        List<string> carInfo = new List<string> {};
        foreach(Car car in allCars)
        {
          carInfo.Add("Model: " + car.GetMake());
          carInfo.Add("Price: " + car.GetPrice().ToString());
          carInfo.Add("Mileage: " + car.GetMileage().ToString());
        }
        return View["view_cars.cshtml", carInfo];
      };
      Post["/car_added"] = _ => {
        Car newCar = new Car (Request.Form["make"], Request.Form["price"], Request.Form["mileage"]);
        return View["car_added.cshtml", newCar];
      };
    }
  }
}
