using System;
using CoffeeMake;
using CoffeeIngredients;
using CoffeeMachine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace  AddIngredient
{
    public static class AddIngredients
    {
        public static void menuAddIngredients()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nМеню кофемашины:");
                Console.WriteLine("1. Проверить ингредиенты");
                Console.WriteLine("2. Добавить ингредиенты");
                Console.Write("Выберите действие: ");

                int button = int.Parse(Console.ReadLine());

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

        public static void addIngredients()
        {
            bool exit = false;
            while (!exit)
            {
                //Console.WriteLine("Добавть ингредиенты мотод тут:");
                Console.WriteLine("1. Добавть воды");
                Console.WriteLine("2. Добавть молоко");
                Console.WriteLine("3. Добавть кофе");
                Console.WriteLine("4. Проверить сколько ингредиентов");
                Console.WriteLine("0. Вернуться назад");

                int button = int.Parse(Console.ReadLine());

                switch (button)
                {
                    case 0:
                         
                        MainMenu.ShowMainMenu();
                        break;
                    case 2:
                         
                        Console.WriteLine();
                        break;
                    case 4:
                         
                        Ingredients.ViewIngridients();
                         
                        break;
                }
            }
        }
    }
}
