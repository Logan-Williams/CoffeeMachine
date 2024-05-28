using CoffeeIngredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class Dirty
    {

        public static void dirtyMachine()
        {
            int derty = 0;

        }
        public static void showDirtyMachine()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Загрязнения кофемашины:");
                Console.WriteLine("1. Проверить загрязнения кофемашины");
                Console.WriteLine("2. Почистить кофемашину");
                Console.Write("Выберите действие: ");

                int button = int.Parse(Console.ReadLine());

                switch (button)
                {
                    case 1:
                       
                        break;
                    case 2:
                       
                        break;
                }
            }

        }
    }
}

