using System;
using System.Collections.Generic;

namespace MVCexample
{
    public class View
    {
        public void DisplayCars(List<Car> cars)
        {
            Console.WriteLine("Список автомобилей:");
            for (int i = 0; i < cars.Count; i++)
            {
                Car car = cars[i];
                Console.WriteLine($"{i}. {car.Make} {car.Model}, год: {car.Year}");
            }
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
