using AddIngredient;
using CoffeeIngredients;
using CoffeeMake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public static class CheckAndDirty
    {
        public static int Dirty { get; set;}

        public static void ShowDirtyMenu()
        {
            while (true)
            {
                Console.WriteLine("Меню загрязнения кофемашины:");
                Console.WriteLine($"Загрязнено на: {Dirty}/4");
                Console.WriteLine("Почистить кофемашину? 1. Да 2. Нет");

                int button = MainMenu.GetUserPrint();

                switch (button)
                {
                    case 1:
                        ClearDirty();
                        break;
                    case 2:
                        MainMenu.ShowMainMenu();
                        break;
                }
            }

        }
        public static void CookingCoffee()
        {

            if (Dirty <= 4)
            {
                Dirty += Coffee.Cup;
            }
            else 
            {
                ShowDirtyMenu();
            }
                
        }
        public static void ClearDirty() 
        {
            if (Dirty == 0)
            {
                Console.WriteLine("Кофемашина уже чистая!");
            }
            else
            {
                Dirty = 0;
            }

        }
        public static void CheckDirty()
        {
            if (Coffee.Cup + Dirty > 4)
            {
                Console.WriteLine("Кофемашинку нужно почистить!");
                ShowDirtyMenu();
            }
            else 
            {
                CookingCoffee();
            }
        }
    }
}

