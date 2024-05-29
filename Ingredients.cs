using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeIngredients
{
    static class Ingredients
    {
        static string Name { get; set; }
        public static int WaterAmound { get; set; } = 1000;
        public static int CoffeAmound { get; set; } = 300;
        public static int MilkAmound { get; set; } = 900;



        public static void ViewIngridients()
        {
            Console.WriteLine($"{Name}:Вода - {WaterAmound} мл, Кофе - {CoffeAmound}г, Молоко - {MilkAmound} мл");
            Console.ReadKey();
        }
    }
}
