using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8._1
{
    internal class Program
    {
        /// <summary>
        /// Создание колекции чисел от 0 до 100
        /// </summary>
        /// <param name="list"></param>
        static void CreateCollection(List<int> list)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int randomNumber = rnd.Next(0, 101);
                list.Add(randomNumber);
            }
            Print(list);
        }
        /// <summary>
        /// Вывод чисел из коллекции
        /// </summary>
        /// <param name="number"></param>
        static void Print(List<int> number)
        {
            for (int i = 0; i < number.Count; i++) Console.Write($" {number[i]}");
            Console.WriteLine();
        }
        /// <summary>
        /// Удаление чисел из коллекции от 25 до 50
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static List<int> Delete(List<int> number)
        {
            number.RemoveAll(x => x > 25 && x < 50);
            return number;
        }
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            Console.Write("Числа от 0 до 100:\n");
            CreateCollection(number);
            number = Delete(number);
            Console.Write("Числа после удаления чисел от 25 до 50:\n");
            Print(number);
            Console.ReadLine();
        }
    }
}
