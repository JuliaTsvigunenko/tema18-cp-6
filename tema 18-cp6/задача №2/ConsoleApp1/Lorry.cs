using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс Грузовик
    class Lorry : Vehicle
    {

        /// <summary>
        /// Максимальная грузоподъемность грузовика
        /// </summary>
        public double MaxCapacity { get; set; }

        /// <summary>
        /// Абстрактный метод для вывода информации о грузовике
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Грузовик: Цена: {Price}\nМаксимальная скорость: {MaxSpeed}\nГод: {Year}\nМаксимальная грузоподъемность: {MaxCapacity}");
        }



    }
}
