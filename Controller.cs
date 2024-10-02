using System.Collections.Generic;

namespace MVCexample
{
    public class Controller
    {
        private Model model;
        private View view;

        public Controller(Model model, View view)
        {
            this.model = model;
            this.view = view;
        }

        public void AddCar(string make, string model, int year)
        {
            this.model.AddCar(make, model, year);
            view.DisplayCars(this.model.ShowAllCars());
        }

        public void RemoveCar(int index)
        {
            this.model.RemoveCar(index);
            view.DisplayCars(this.model.ShowAllCars());
        }

        public void ShowAllCars()
        {
            List<Car> cars = this.model.ShowAllCars();
            view.DisplayCars(cars);
        }
    }
}
