using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс Гараж
    class Garage
    {

        /// <summary>
        /// Коллекция для хранения транспортных средств
        /// </summary>
        private List<Vehicle> vehicles = new List<Vehicle>();

        /// <summary>
        /// Метод для добавления транспортного средства в гараж
        /// </summary>
        /// <param name="vehicle"></param>
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        /// <summary>
        /// Метод для вывода информации о всех транспортных средствах в гараже
        /// </summary>
        public void DisplayAllVehiclesInfo()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayInfo();
            }
        }


        /// <summary>
        /// Метод для вывода информации о всех автомобилях в гараже
        /// </summary>
        public void DisplayCarsInfo()
        {
            Console.WriteLine("Автомобили:");
            foreach (var vehicle in vehicles)
            {
                if (vehicle is Car)
                {
                    vehicle.DisplayInfo();
                }
            }
        }

        /// <summary>
        /// Метод для вывода информации о велосипедах в гараже
        /// </summary>
        public void DisplayBicyclesInfo()
        {
            Console.WriteLine("Велосипеды:");
            foreach (var vehicle in vehicles)
            {
                if (vehicle is Bicycle)
                {
                    vehicle.DisplayInfo();
                }
            }
        }

        /// <summary>
        /// Метод для вывода информации о всех грузовиках в гараже
        /// </summary>
        public void DisplayLorriesInfo()
        {
            Console.WriteLine("Грузовики:");
            foreach (var vehicle in vehicles)
            {
                if (vehicle is Lorry)
                {
                    vehicle.DisplayInfo();
                }
            }
        }


    }
}
