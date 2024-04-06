using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Производный класс Коммерческое программное обеспечение
    class CommercialSoftware : Software
    {
        /// <summary>
        /// поле цены
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// поле даты установки
        /// </summary>
        public DateTime InstallationDate { get; set; }
        /// <summary>
        /// поле дней действия
        /// </summary>
        public int ValidityDays { get; set; }

        /// <summary>
        /// вывод информации
        /// </summary>
        public override void DisplayInformation()
        {
            Console.WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}\nДата установки: {InstallationDate.ToShortDateString()}\nДней действия: {ValidityDays}");
        }

        public override bool IsUsable() //можно использовать
        {
            return DateTime.Now <= InstallationDate.AddDays(ValidityDays); // return DateTime.Now <= ДатаУстановки.AddDays(ДнейДействия);
        }







    }
}
