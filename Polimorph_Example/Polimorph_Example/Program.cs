using System;
using Polimorph_Example.Products;

namespace Polimorph_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                "Клиент",
                "Москва",
                5000,
                550
                );

            Console.WriteLine("Список товаров:");

            CPU intel_4770 = new CPU(
                "Intel 4770",
                700,
                "Intel"
                );

            Console.WriteLine("Процессор:");
            Console.WriteLine("Название: " + intel_4770.Name);
            Console.WriteLine("Цена: " + intel_4770.Price);
            Console.WriteLine("Производитель: " + intel_4770.Brand);
            Console.WriteLine(new String('-', 25));

            GPU gtx_780 = new GPU(
                "GTX 780",
                1000,
                "NVIDIA"
                );

            Console.WriteLine("Видеокарта:");
            Console.WriteLine("Название: " + gtx_780.Name);
            Console.WriteLine("Цена: " + gtx_780.Price);
            Console.WriteLine("Производитель: " + gtx_780.Brand);
            Console.WriteLine(new String('-', 25));

            GPU r9_270x = new GPU(
                "R9 270X",
                800,
                "AMD"
                );

            Console.WriteLine("Видеокарта:");
            Console.WriteLine("Название: " + r9_270x.Name);
            Console.WriteLine("Цена: " + r9_270x.Price);
            Console.WriteLine("Производитель: " + r9_270x.Brand);
            Console.WriteLine(new String('-', 25));

            Motherboard maximus_7_ranger = new Motherboard(
                "Maximus VII Ranger",
                500,
                "ASUS",
                "ATX",
                "Z97"
                );

            Console.WriteLine("Материнская плата:");
            Console.WriteLine("Название: " + maximus_7_ranger.Name);
            Console.WriteLine("Цена: " + maximus_7_ranger.Price);
            Console.WriteLine("Производитель: " + maximus_7_ranger.Brand);
            Console.WriteLine("Формфактор: " + maximus_7_ranger.Form);
            Console.WriteLine("Чипсет: " + maximus_7_ranger.Chipset);
            Console.WriteLine(new String('-', 25));

            Power rm850i = new Power(
                "RM850i",
                400,
                "Corsair",
                850
                );

            Console.WriteLine("Блок питания:");
            Console.WriteLine("Название: " + rm850i.Name);
            Console.WriteLine("Цена: " + rm850i.Price);
            Console.WriteLine("Производитель: " + rm850i.Brand);
            Console.WriteLine("Мощность: " + rm850i.Value);
            Console.WriteLine(new String('-', 25));

            Power cx550 = new Power(
                "CX550",
                100,
                "Corsair",
                550
                );

            Console.WriteLine("Блок питания:");
            Console.WriteLine("Название: " + rm850i.Name);
            Console.WriteLine("Цена: " + rm850i.Price);
            Console.WriteLine("Производитель: " + rm850i.Brand);
            Console.WriteLine("Мощность: " + rm850i.Value);
            Console.WriteLine(new String('-', 25));


            Product[] products = new Product[] {
                intel_4770,
                gtx_780,
                r9_270x,
                maximus_7_ranger,
                rm850i,
                cx550
            };

            Check check = new Check();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте, {user.Name}. Ваш баланс: {user.Balance}");
                Console.WriteLine(new String('-', 25));

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i+1} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine(new String('-', 25));
                Console.WriteLine("Выберете номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str) - 1;

                if (productNumber >= 0 && productNumber < products.Length)
                {

                    if (products[productNumber].Price < user.Balance)
                    {
                        check.Buy(user, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine(new String('-', 25));
                        Console.WriteLine("У Вас недостаточно средств!");
                        Console.WriteLine(new String('-', 25));
                    }

                }
                else
                {
                    Console.WriteLine(new String('-', 25));
                    Console.WriteLine("Таких товаров нет!");
                    Console.WriteLine(new String('-', 25));
                }
            }
        }
    }
}
