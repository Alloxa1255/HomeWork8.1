using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вашу Ф.И.О:");
            string fio = Console.ReadLine();
            Console.Write("Введите вашу улицу:");
            string street = Console.ReadLine();
            Console.Write("Введите ваш номер дома:");
            string house = Console.ReadLine();
            Console.Write("Введите ваш номер квартиры:");
            string apartment = Console.ReadLine();
            Console.Write("Введите ваш мобильный телефон:");
            string mobilePhone = Console.ReadLine();
            Console.Write("Введите ваш домашний телефон:");
            string housePhone = Console.ReadLine();
            XElement person = new XElement("Person",
                new XAttribute("name", fio),
                new XElement("Address",
                    new XElement("Street", street),
                    new XElement("HouseNumber", house),
                    new XElement("FlatNumber", apartment)
                    ),
                new XElement("Phones",
                    new XElement("MobilePhone", mobilePhone),
                    new XElement("FlatPhone", housePhone)
                    )
                );
            person.Save("Person.xml");

            Console.WriteLine("Xml файл сохранен");
        }
    }
}
