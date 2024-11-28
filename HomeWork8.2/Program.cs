using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8._2
{
    internal class Program
    {
        /// <summary>
        /// Создание справочника
        /// </summary>
        /// <param name="people"></param>
        static void CreateDirectory(Dictionary<string, string> people)
        {
            string numberPhone, name;
            while (true)
            {
                Console.Write("\nВведите номер телефона:");
                numberPhone = Console.ReadLine();
                if (numberPhone == string.Empty)
                {
                    break;
                }
                Console.Write("Введите имя владельца:");
                name = Console.ReadLine();
                people.Add(numberPhone, name);
            }
        }
        /// <summary>
        /// Вывод на экран справочника
        /// </summary>
        /// <param name="people"></param>
        static void PrintDirectory(Dictionary<string, string> people)
        {
            Console.Write("\nВведите номер для нахождения владельца:");
            string searchPhone = Console.ReadLine();
            if (people.TryGetValue(searchPhone, out string value))
            {
                Console.WriteLine($"Имя владельца данного телефона:{value}\n");
            }
            else
            {
                Console.WriteLine("Владельца данного номера не найдено\n");
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> people = new Dictionary<string, string>();
            char key = 'a';
            do
            {
                Console.WriteLine("1-Сохранение телефона в справочник\n2-Поиск по номеру телефона\n0-Выход из справочника");
                key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case '1':
                        CreateDirectory(people);
                        break;
                    case '2':
                        PrintDirectory(people);
                        break;
                    case '0':
                        break;

                }
            }while (key!='0');
        }
    }
}
