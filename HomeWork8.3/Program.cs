using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8._3
{
    internal class Program
    {
        static void SaveNumber(HashSet<int> numberRepite)
        {
            while (true)
            {
                Console.Write("Введите число для сохранения в коллекцию:");
                int number = int.Parse(Console.ReadLine());
                if (!numberRepite.Contains(number))
                {
                    numberRepite.Add(number);
                }
                else
                {
                    Console.WriteLine("Данное число уже добавлено");
                }
            }
        }
        static void Main(string[] args)
        {
            HashSet<int> numberRepite = new HashSet<int>();
            SaveNumber(numberRepite);
        }
    }
}
