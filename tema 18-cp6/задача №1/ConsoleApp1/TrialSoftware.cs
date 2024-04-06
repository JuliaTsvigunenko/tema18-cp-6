using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Производный класс Пробное программное обеспечение
    class TrialSoftware : Software
    {

        /// <summary>
        /// поле дата установки
        /// </summary>
        public DateTime InstallationDate { get; set; }
        /// <summary>
        /// поле дней пробного периода (бесплатного исполоьзования)
        /// </summary>
        public int TrialDays { get; set; }

        /// <summary>
        /// вывод информации
        /// </summary>
        public override void DisplayInformation()
        {
            Console.WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}\nДата установки: {InstallationDate.ToShortDateString()}\nПробный период в днях: {TrialDays}");
        }

        public override bool IsUsable()
        {
            return DateTime.Now <= InstallationDate.AddDays(TrialDays); // return DateTime.Now <= ДатаУстановки.AddDays(ДнейПробногоПериода);
        }





    }
}
