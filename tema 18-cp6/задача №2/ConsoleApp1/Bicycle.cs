using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс Велосипед
    class Bicycle : Vehicle
    {


        /// <summary>
        /// Количество пассажиров, которых может перевозить велосипед одновременно.
        /// </summary>
        public int MaxPassenger { get; set; }

        /// <summary>
        /// Абстрактный метода для вывода информации о велосипеде
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Велосипед:\t Цена: {Price}\nМаксимальная скорость: {MaxSpeed}\nГод: {Year}\nМаксимум пассажиров: {MaxPassenger}");
        }






    }
}
