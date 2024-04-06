using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Абстрактный класс Транспортное средство
    public abstract class Vehicle
    {
        /// <summary>
        /// поле цена для транспортного средства
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// поле MaxСкорости для транспортного средства
        /// </summary>
        public int MaxSpeed { get; set; }
        /// <summary>
        /// поле года
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Абстрактный метод, он реализован в каждом потомке
        /// </summary>
        public abstract void DisplayInfo();









    }
}
