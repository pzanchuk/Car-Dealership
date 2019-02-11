using System;
using System.Collections.Generic;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Car porsche = new Car("2014 Porsche 911", 114991, 7864);
      Car ford = new Car("2011 Ford F450", 55995, 100241);
      Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
      Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);
      Car toyota = new Car("Corolla SE", 8000, 125000 );

      List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes, toyota };

      Console.WriteLine("Enter maximum price: ");
      int maxPrice = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter maximum milage: ");
      int maxMilage = int.Parse(Console.ReadLine());

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice) && automobile.GetMiles() <= maxMilage)
        {
          CarsMatchingSearch.Add(automobile);
        }
      }
      int sizeOfCarsMatchingSearch = CarsMatchingSearch.Count;

      if(sizeOfCarsMatchingSearch == 0)
      {
        Console.WriteLine("Sorry thre are no cars under " + maxPrice);
      }else
      {

        foreach(Car automobile in CarsMatchingSearch)
        {

          Console.WriteLine("----------------------");
          Console.WriteLine(automobile.MessageAboutCar());
          Console.WriteLine(automobile.GetMakeModel());
          Console.WriteLine(automobile.GetMiles() + " miles");
          Console.WriteLine("$" + automobile.GetPrice());
        }
      }
    }
  }

}
