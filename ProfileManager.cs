using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    class Profile 
    { 
        public string Name { get; set; }
        public int Coffee {  get; set; }
        public int Milk {  get; set; }
        public int Water {  get; set; }
        public int Cup {  get; set; }

        public Profile(string name, int coffee, int milk, int water,int cup)
        {
            Name = name;
            Coffee = coffee;
            Milk = milk;
            Water = water;
            Cup = cup;
        }
    }

    public static class ProfileManager
    {
        static List<Profile> ProfileList = new List<Profile>();

        public static void CreateProfile()
        {
            Console.WriteLine("Скольео кофе будет в рецепте?");
            int resultCoffee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько молока будет в рецепте?");
            int resultMilk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько воды будет в рецепте?");
            int resultWater = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Название профиля");
            string resultName = Console.ReadLine();
            Console.WriteLine(resultMilk);
            Console.WriteLine(resultCoffee);
            Console.WriteLine(resultWater);
            Console.WriteLine(resultName);
            Console.ReadLine();
        }
        
    }

}
