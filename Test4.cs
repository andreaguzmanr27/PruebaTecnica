using System;
using System.Collections;
using System.Linq;

namespace classCarAndLinq
{
  public class Car
  {
    public string brand { get; set; }
    public string color { get; set; }
    public int model { get; set; }
  }

  public class Test4
  {
    public static void Main(string[] args)
    {
      ArrayList arrList = new ArrayList();
      arrList.Add(
      new Car
      {
        brand = "BMW", color = "Red", model = 2018
      });
      arrList.Add(
      new Car
      {
        brand = "Mercedes Benz", color = "Grey", model = 2020
      });
      arrList.Add(
      new Car
      {
        brand = "Renault", color = "Black", model = 2010
      });
      arrList.Add(
      new Car
      {
        brand = "KIA", color = "Blue", model = 2015
      });

      string date = DateTime.Now.ToString("yyyy");
      var query = from Car car in arrList
        where car.model > ((Int32.Parse(date)) - 5)
        select car;

        foreach (Car s in query)
        Console.WriteLine(s.brand + ": " + s.model);
    }
  }
}
