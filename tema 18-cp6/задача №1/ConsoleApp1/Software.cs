using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Абстрактный класс Программное обеспечение
    abstract class Software
    {
        /// <summary>
        /// поле название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// поле производитель
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// // Абстрактные методы, которые должны быть реализованы в производных классах
        /// </summary>
        public abstract void DisplayInformation();
        public abstract bool IsUsable();












    }
}
