using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14.Абстрактные_классы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя кошки:");
            string catName = Console.ReadLine();
            Console.WriteLine("\nВведите имя собаки:");
            string dogName = Console.ReadLine();
            Cat cat = new Cat(catName);
            cat.ShowInfo();
            Dog dog = new Dog(dogName);
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
