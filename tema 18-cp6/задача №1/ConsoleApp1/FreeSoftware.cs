using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Производный класс Свободное программное обеспечение
    class FreeSoftware : Software
    {

        /// <summary>
        /// вывод информации
        /// </summary>
        public override void DisplayInformation()
        {
            Console.WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}");
        }

        public override bool IsUsable()
        {
            return true;
        }


    }
}
