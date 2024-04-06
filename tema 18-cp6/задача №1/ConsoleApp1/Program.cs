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






            List<Software> softwareDatabase = new List<Software>();

            while (true)
            {
                Console.WriteLine("1. Программное обеспечение");
                Console.WriteLine("2. Пробное программное обеспечение");
                Console.WriteLine("3. Коммерческое программное обеспечение");
                Console.WriteLine("4. Вывести информацию о программном обеспечении");
                Console.WriteLine("5. Выход");
                Console.Write("Введите ваш выбор: ");

                int choice; //выбор
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите число из предложенных.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите название: ");
                        string freeName = Console.ReadLine();
                        Console.Write("Введите производителя: ");
                        string freeManufacturer = Console.ReadLine();
                        softwareDatabase.Add(new FreeSoftware { Name = freeName, Manufacturer = freeManufacturer });
                        Console.WriteLine("Свободное программное обеспечение успешно добавлено.");
                        break;

                    case 2:
                        Console.Write("Введите название: ");
                        string trialName = Console.ReadLine();
                        Console.Write("Введите производителя: ");
                        string trialManufacturer = Console.ReadLine();
                        Console.Write("Введите дату установки (MM/dd/yyyy): ");
                        DateTime trialInstallDate;
                        if (!DateTime.TryParse(Console.ReadLine(), out trialInstallDate))
                        {
                            Console.WriteLine("Неверный формат даты. Пожалуйста, введите в формате MM/dd/yyyy.");
                            break;
                        }
                        Console.Write("Введите дни пробного периода: ");
                        int trialDays; //дни пробного периода
                        if (!int.TryParse(Console.ReadLine(), out trialDays))
                        {
                            Console.WriteLine("Неверный ввод для дней пробного периода. Пожалуйста, введите число.");
                            break;
                        }
                        softwareDatabase.Add(new TrialSoftware { Name = trialName, Manufacturer = trialManufacturer, InstallationDate = trialInstallDate, TrialDays = trialDays });
                        Console.WriteLine("Пробное программное обеспечение успешно добавлено.");
                        break;

                    case 3:
                        Console.Write("Введите название: ");
                        string commercialName = Console.ReadLine();
                        Console.Write("Введите производителя: ");
                        string commercialManufacturer = Console.ReadLine();
                        Console.Write("Введите цену: ");
                        decimal commercialPrice;
                        if (!decimal.TryParse(Console.ReadLine(), out commercialPrice))
                        {
                            Console.WriteLine("Неверный ввод для цены. Пожалуйста, введите десятичное число.");
                            break;
                        }
                        Console.Write("Введите дату установки (MM/dd/yyyy): ");
                        DateTime commercialInstallDate;
                        if (!DateTime.TryParse(Console.ReadLine(), out commercialInstallDate))
                        {
                            Console.WriteLine("Неверный формат даты. Пожалуйста, введите в формате MM/dd/yyyy.");
                            break;
                        }
                        Console.Write("Введите дни действия: ");
                        int commercialValidityDays;
                        if (!int.TryParse(Console.ReadLine(), out commercialValidityDays))
                        {
                            Console.WriteLine("Неверный ввод для дней действия. Пожалуйста, введите номер.");
                            break;
                        }
                        softwareDatabase.Add(new CommercialSoftware { Name = commercialName, Manufacturer = commercialManufacturer, Price = commercialPrice, InstallationDate = commercialInstallDate, ValidityDays = commercialValidityDays });
                        Console.WriteLine("Коммерческое программное обеспечение успешно добавлено.");
                        break;

                    case 4:
                        Console.WriteLine("Информация о программном обеспечении:");
                        foreach (var software in softwareDatabase)
                        {
                            software.DisplayInformation();
                            Console.WriteLine($"Пригодный: {software.IsUsable()}");
                            Console.WriteLine();
                        }
                        break;

                    case 5:
                        Console.WriteLine("Выход из программы...");
                        return;

                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, введите допустимый вариант.");
                        break;



                }


                Console.ReadKey();







            }



















        }
    }
}
