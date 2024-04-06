using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс Автомобиль
    class Car : Vehicle
    {

        /// <summary>
        /// Мощность двигателя автомобиля
        /// </summary>
        public int Power { get; set; }

        /// <summary>
        /// Реализация абстрактного метода для вывода информации об автомобиле
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Автомобиль:\t Цена: {Price}\nМаксимальная скорость: {MaxSpeed}\nГод: {Year}\nМощность двигателя автомобиля: {Power}");
        }

    }
}
