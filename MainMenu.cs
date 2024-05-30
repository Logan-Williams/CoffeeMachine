using CoffeeMake;
using CoffeeIngredients;
using AddIngredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace CoffeeMachine
{
    static class MainMenu
    {

        public static void ShowMainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nМеню кофемашины:");
                Console.WriteLine("1. Сделать кофе");
                Console.WriteLine("2. Добавить ингредиенты");
                Console.WriteLine("3. Проверить ингредиенты");
                Console.WriteLine("4. Проверить или прочистить кофемашинку");
                Console.WriteLine("8. Выход");
                Console.Write("Выберите действие: ");

                int button = GetUserPrint();// создать отдельно метод 

                switch (button)
                {
                    case 1:
                        Console.Clear();
                        Coffee.MakeCoofee();
                        break;
                    case 2:
                        Console.Clear();
                        AddMenu.AddIngredients();
                        break;
                    case 3:
                        Console.Clear();
                        Ingredients.ViewIngridients();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        CheckAndDirty.ShowDirtyMenu();
                        Console.Clear();
                        break;
                }

            }

        }
        public static int GetUserPrint()
        {
            while (true)
            {
                try
                {
                    int result = Convert.ToInt32(Console.ReadLine());
                    return result;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка, неверный формат ввода");
                    Console.WriteLine("Повторите попытку:");
                }
            }   
        }
    }

}
