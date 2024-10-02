using System;
using System.Collections.Generic;

namespace MVCexample
{
    public struct Car
    {
        public string Make;
        public string Model;
        public int Year;

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }

    public class Model
    {
        private List<Car> cars;

        public Model()
        {
            cars = new List<Car>
            {
                new Car("Toyota", "Corolla", 2020),
                new Car("Ford", "Mustang", 2022),
                new Car("Honda", "Civic", 2018),
                new Car("BMW", "X5", 2021),
                new Car("Mercedes", "C-Class", 2019)
            };
        }

        public void AddCar(string make, string model, int year)
        {
            Car newCar = new Car(make, model, year);
            cars.Add(newCar);
            Console.WriteLine($"Добавлена машина: {make} {model}, год: {year}");
        }

        public void RemoveCar(int index)
        {
            if (index >= 0 && index < cars.Count)
            {
                Car carToRemove = cars[index];
                cars.RemoveAt(index);
                Console.WriteLine($"Удалена машина: {carToRemove.Make} {carToRemove.Model}, год: {carToRemove.Year}");
            }
            else
            {
                Console.WriteLine("Неверный индекс.");
            }
        }

        public List<Car> ShowAllCars()
        {
            return cars;
        }
    }
}
