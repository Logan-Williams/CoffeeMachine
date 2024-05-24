using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeRecipeClass
{
    public class CoffeeRecipeClass// меню рецептов 
    {
        public string Name { get; set; }
        public int WaterAmound { get; set; }
        public int CoffeAmound { get; set; }
        public int MilkAmound { get; set; }

        public CoffeeRecipeClass(string name, int waterAmoubd, int coffeAmound, int milkAmmound)
        {
         Name = name;
         WaterAmound = waterAmoubd;
         CoffeAmound = coffeAmound;
         MilkAmound = milkAmmound;
        }
        public override string ToString()
        {
         return $"{Name}:Вода - {WaterAmound} мл, Кофе - {CoffeAmound}г, Молоко - {MilkAmound} мл";
        }

    }
    
}
