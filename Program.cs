using System;

namespace MVCexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            View view = new View();
            Controller controller = new Controller(model, view);

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Меню управления автомобилями:");
                Console.WriteLine("1. Показать все автомобили");
                Console.WriteLine("2. Добавить автомобиль");
                Console.WriteLine("3. Удалить автомобиль");
                Console.WriteLine("4. Выйти");
                Console.Write("Выберите действие (1-4): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        controller.ShowAllCars();
                        break;
                    case "2":
                        AddCar(controller);
                        break;
                    case "3":
                        RemoveCar(controller);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
                    Console.ReadKey();
                }
            }
        }

        static void AddCar(Controller controller)
        {
            Console.Write("Введите марку автомобиля: ");
            string make = Console.ReadLine();
            Console.Write("Введите модель автомобиля: ");
            string model = Console.ReadLine();
            Console.Write("Введите год выпуска: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year) || year < 1886 || year > DateTime.Now.Year)
            {
                Console.Write("Некорректный год. Попробуйте снова: ");
            }

            controller.AddCar(make, model, year);
        }

        static void RemoveCar(Controller controller)
        {
            Console.Write("Введите индекс автомобиля для удаления: ");
            int index;
            if (int.TryParse(Console.ReadLine(), out index))
            {
                controller.RemoveCar(index);
            }
            else
            {
                Console.WriteLine("Неверный индекс.");
            }
        }
    }
}
