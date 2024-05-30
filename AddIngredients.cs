using System;
using CoffeeMake;
using CoffeeIngredients;
using CoffeeMachine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddIngredient
{
    public class AddMenu
    {
        const int maxWater = 1000;
        const int maxCoffee = 300;
        const int maxMilk = 900;

        public static void menuAddIngredients()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nМеню кофемашины:");
                Console.WriteLine("1. Проверить ингредиенты");
                Console.WriteLine("2. Добавить ингредиенты");
                Console.Write("Выберите действие: ");

                int button = MainMenu.GetUserPrint();

                switch (button)
                {
                    case 1:

                        Ingredients.ViewIngridients();

                        break;
                    case 2:

                        Console.WriteLine();
                        break;
                }
            }
        }

        public static void AddIngredients()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Добавть воды");
                Console.WriteLine("2. Добавть молоко");
                Console.WriteLine("3. Добавть кофе");
                Console.WriteLine("0. Вернуться назад");

                int button = MainMenu.GetUserPrint();

                switch (button)
                {
                    case 0:
                        MainMenu.ShowMainMenu();
                        break;
                    case 1:
                        ShowWaterMenu();
                        break;
                    case 2:
                        ShowMilkMenu();
                        break;
                    case 3:
                        ShowCoffeeMenu();
                        break;

                }
            }
        }

        public static void ShowWaterMenu()
        {
            Console.WriteLine($"Воды - {Ingredients.WaterAmound}/{maxWater}");
            Console.WriteLine($"Сколко воды нужно налить?");
            int result = Convert.ToInt32(Console.ReadLine());
            AddWater(result);
        }
        public static void AddWater(int result)
        {
            if (result + Ingredients.WaterAmound <= maxWater)
            {
                Ingredients.WaterAmound += result;
                Console.WriteLine("Вода успешно добавлена!");
            }
            else
            {
                Console.WriteLine("Перелив воды!");
            }
            Console.ReadKey();
            AddIngredients();
        }

        public static void ShowMilkMenu()
        {
            Console.WriteLine($"Молока - {Ingredients.MilkAmound}/{maxMilk}");
            Console.WriteLine($"Сколко молока нужно налить?");
            int result = Convert.ToInt32(Console.ReadLine());
            AddMilk(result);
        }
        public static void AddMilk(int result)
        {
            if (result + Ingredients.MilkAmound <= maxMilk)
            {
                Ingredients.MilkAmound += result;
                Console.WriteLine("Молоко успешно добавлено!");
            }
            else
            {
                Console.WriteLine("Перелив молока!");
            }
            Console.ReadKey();
            AddIngredients();
        }

        public static void ShowCoffeeMenu()
        {
            Console.WriteLine($"Кофе - {Ingredients.CoffeAmound}/{maxCoffee}");
            Console.WriteLine($"Сколко кофе нужно добавить?");
            int result = Convert.ToInt32(Console.ReadLine());
            AddCoffee(result);
        }
        public static void AddCoffee(int result)
        {
            if (result + Ingredients.CoffeAmound <= maxCoffee)
            {
                Ingredients.CoffeAmound += result;
                Console.WriteLine("Кофе успешно добавлено!");
            }
            else
            {
                Console.WriteLine("Переполнение кофе!");
            }
            Console.ReadKey();
            AddIngredients();
        }
    }
}