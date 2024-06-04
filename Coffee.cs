using AddIngredient;
using CoffeeMachineLogi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeIngredients;

namespace CoffeeMake
{
    public static class Coffee// меню рецептов 
    {
        private const int waterLatte = 100;
        private const int coffeeLatte = 30;
        private const int milkLatte = 50;

        private const int waterEspresso = 100;
        private const int coffeeEspresso = 20;
        private const int milkEspresso = 50;
        public static int Cup = 0;

        public static void MakeCoofee()
        {
            Console.WriteLine("\nКакой кофе сделать?:");
            Console.WriteLine("1. Приготовить Латте");
            Console.WriteLine("2. Приготовить Эспрессо");
            Console.WriteLine("0. Вернуться назад");
            Console.Write("Выберите действие: ");

            int button = MainMenu.GetUserPrint();

            switch (button)
            {
                case 0:
                    Console.Clear();
                    MainMenu.ShowMainMenu();
                    break;
                case 1:
                    Console.Clear();
                    
                    CreateCoffee(1);
                    break;
                case 2:
                    Console.Clear();
                    
                    CreateCoffee(2);
                    break;
                case 3:
                    Ingredients.ViewIngridients();
                    break;
            }

        }
        private static int CupAdd()
        {
            Console.WriteLine("Скролько кружек вы хотите?");
            Cup = Convert.ToInt32(Console.ReadLine());
            return Cup;
        }
        public static void CreateCoffee(int coffee)
        {
            Cup = CupAdd();
            int reqiredWater = 0, reqiredCoffee = 0, reqiredMilk = 0;
            switch (coffee)
            {
                case 1:
                    reqiredWater = waterLatte;
                    reqiredCoffee = coffeeLatte;
                    reqiredMilk = coffeeLatte;
                    break;
                case 2:
                    reqiredWater = waterEspresso;
                    reqiredCoffee = coffeeEspresso;
                    reqiredMilk = milkEspresso;
                    break;
                default:
                    Console.WriteLine("Неверный выбор кофе");
                    break;
            }
            if (CheckIngredient(reqiredWater * Cup, reqiredCoffee * Cup, reqiredMilk * Cup))
            {
                CheckAndDirty.CheckDirty();
                Ingredients.WaterAmound -= reqiredWater * Cup;
                Ingredients.CoffeAmound -= reqiredCoffee * Cup;
                Ingredients.MilkAmound -= reqiredMilk * Cup;
                if (reqiredCoffee == 20)
                {
                    Console.WriteLine($"Еспрессо приготовленно к количестве {Cup} шт");
                    LogiCoffee.AddHistoryCoking("Еспрессо",Cup);
                }
                else
                {
                    Console.WriteLine($"Латте приготовленно к количестве {Cup} шт");
                    LogiCoffee.AddHistoryCoking("Латте", Cup);
                }
                Console.ReadKey();
            }
        }
        public static bool CheckIngredient(int water, int milk, int coffee)
        {
            if (water <= Ingredients.WaterAmound && milk <= Ingredients.MilkAmound && coffee <= Ingredients.CoffeAmound)
            {
                return true;
            }
            return false;
        }
    }

}
