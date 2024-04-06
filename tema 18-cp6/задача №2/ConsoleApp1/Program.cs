using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Создание гаража
            Garage garage = new Garage();

            // Добавление транспортных средств в гараж с помощью switch case
            while (true)
            {
                Console.WriteLine("Выберите тип транспортного средства для добавления:");
                Console.WriteLine("1. Добавить в список Автомобиль");
                Console.WriteLine("2. Добавить в список Велосипед");
                Console.WriteLine("3. Добавить в список Грузовик");
                Console.WriteLine("4. Вывести все автомобили из списка");
                Console.WriteLine("5. Вывести все велосипеды из списка");
                Console.WriteLine("6. Вывести все грузовики из списка");
                Console.WriteLine("0. Завершить добавление");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Car car = CreateCar(); // Создание автомобиля
                        garage.AddVehicle(car); // Добавление автомобиля в гараж
                        break;
                    case "2":
                        Bicycle bicycle = CreateBicycle();
                        garage.AddVehicle(bicycle);
                        break;
                    case "3":
                        Lorry lorry = CreateLorry();
                        garage.AddVehicle(lorry);
                        break;
                    case "4":
                        // Показать все автомобили в гараже
                        garage.DisplayCarsInfo();
                        break;
                    case "5":
                        // Показать все велосипеды в гараже
                        garage.DisplayBicyclesInfo();
                        break;
                    case "6":
                        // Показать все грузовики в гараже
                        garage.DisplayLorriesInfo();
                        break;
                    case "0":
                        // Завершение добавления транспортных средств
                        Console.WriteLine("Добавление транспортных средств завершено.");
                        // Вывод информации о всех добавленных транспортных средствах в гараж
                        garage.DisplayAllVehiclesInfo();
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод. Пожалуйста, повторите попытку.");
                        break;
                }

                if (choice == "0")
                    break; // выход из цикла, если пользователь выбрал завершение добавления
            }
        }

        static Car CreateCar()
        {
            Car car = new Car();
            Console.WriteLine("Введите информацию об автомобиле:");
            Console.Write("Цена: ");
            car.Price = double.Parse(Console.ReadLine());
            Console.Write("Максимальная скорость: ");
            car.MaxSpeed = int.Parse(Console.ReadLine());
            Console.Write("Год выпуска: ");
            car.Year = int.Parse(Console.ReadLine());
            Console.Write("Мощность автомобиля: ");
            car.Power = int.Parse(Console.ReadLine());
            return car;
        }

        static Bicycle CreateBicycle()
        {
            Bicycle bicycle = new Bicycle();
            Console.WriteLine("Введите информацию о велосипеде:");
            Console.Write("Цена: ");
            bicycle.Price = double.Parse(Console.ReadLine());
            Console.Write("Максимальная скорость: ");
            bicycle.MaxSpeed = int.Parse(Console.ReadLine());
            Console.Write("Год выпуска: ");
            bicycle.Year = int.Parse(Console.ReadLine());
            Console.Write("Количество пассажиров: ");
            bicycle.MaxPassenger = int.Parse(Console.ReadLine());
            return bicycle;
        }

        static Lorry CreateLorry()
        {
            Lorry lorry = new Lorry();
            Console.WriteLine("Введите информацию о грузовике:");
            Console.Write("Цена: ");
            lorry.Price = double.Parse(Console.ReadLine());
            Console.Write("Максимальная скорость: ");
            lorry.MaxSpeed = int.Parse(Console.ReadLine());
            Console.Write("Год выпуска: ");
            lorry.Year = int.Parse(Console.ReadLine());
            Console.Write("Максимальная ёмкость: ");
            lorry.MaxCapacity = double.Parse(Console.ReadLine());
            return lorry;

            Console.ReadKey();
        }

    }
    




}
