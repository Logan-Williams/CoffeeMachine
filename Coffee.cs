using AddIngredient;
using CoffeeMachine;
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

        public static void MakeCoofee()
        {
            Console.WriteLine("\nКакой кофе сделать?:");
            Console.WriteLine("1. Приготовить Латте");
            Console.WriteLine("2. Приготовить Эспрессо");
            Console.WriteLine("0. Вернуться назад");
            Console.Write("Выберите действие: ");

            int button = int.Parse(Console.ReadLine());

            switch (button)
            {
                case 0:
                    MainMenu.ShowMainMenu();
                    break;
                case 1:
                    CreateCoffee(1);
                    break;
                case 2:
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
            int cup = Convert.ToInt32(Console.ReadLine());
            return cup;
        }
        public static void CreateCoffee(int coffee)
        {
            int cup = CupAdd();
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
            if (CheckIngredient(reqiredWater * cup, reqiredCoffee * cup, reqiredMilk * cup )) 
            {
                Ingredients.WaterAmound -= reqiredWater * cup;
                Ingredients.CoffeAmound -= reqiredCoffee * cup;
                Ingredients.MilkAmound -= reqiredMilk * cup;
                if (reqiredCoffee == 20) 
                {
                    Console.WriteLine($"Еспрессо приготовленно к количестве {cup} шт") ;
                }
                else 
                {
                    Console.WriteLine($"Латте приготовленно к количестве {cup} шт");
                }
            }
        }
        public static bool CheckIngredient(int water, int milk, int coffee) 
        {
            if (water >= Ingredients.WaterAmound && milk >= Ingredients.MilkAmound && coffee >= Ingredients.CoffeAmound ) 
            { 
                return true;
            }
            return false;
        }
    }

}
