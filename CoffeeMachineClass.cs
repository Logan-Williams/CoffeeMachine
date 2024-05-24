using System;
using CoffeeRecipeClass;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
   public class CoffeMachine
 {
    private bool isOn;
    public bool isDirty;
    private List<string> log = new List<string>();
    private List<CoffeeRecipeClass.CoffeeRecipeClass> recipes;
   
    public CoffeMachine()
    {
        isOn = false;
        isDirty = false;
        recipes = new List<CoffeeRecipeClass.CoffeeRecipeClass>
        {
        new CoffeeRecipeClass.CoffeeRecipeClass("Latte", 200, 20, 150),
        new CoffeeRecipeClass.CoffeeRecipeClass("Espresso", 50, 80, 0)
        };
        log = new List<string>();
    }
    public void TurnOn()
    {
        if (!isOn)
        {
            isOn=true;
            Console.WriteLine("Кофемашинка включена");
        }
        else
        {
            Console.WriteLine("Кофеммашинка уже включена");
        }
    }
    public void TurnOff()
    { 
        if (isOn)
        {
            isOn=false;
            Console.WriteLine("Кофемашинка выключена");
        }
        else
        {
            Console.WriteLine("Кофемашинка уже выключена");
        }
    }

    public void AddRecipe(CoffeeRecipeClass.CoffeeRecipeClass recipe)
    {
        recipes.Add(recipe);
        Console.WriteLine($"Рецепт {recipe.Name} добавлен.");
    }
    public void ShowRecipes()
    {
        Console.WriteLine("Доступные рецепты");
        foreach (var recipe in recipes)
        {
            Console.WriteLine(recipe);
        }
    }
    public void MakeDirty()
    {
        if (!isDirty)
        {
            isDirty = true;
            Console.WriteLine("Кофемашинка загрязнена");
        }
        else 
        {
            Console.WriteLine("Кофемашинка чистая");
        }
    }
        public void Clean()
        {
            if (isDirty)
            {
                isDirty=false;
                Console.WriteLine("Кофемашинка очищена");
            }
            else
            {
                Console.WriteLine("Кофемашинка уже чистая");
            }
        }

    public void MakeCoffe(string recipeName)
    {
            if (!isOn)
            {
                Console.WriteLine("Кофемашина выключена. Включите её перед приготовлением кофе.");
                return;
            }

            if (isDirty)
            {
                Console.WriteLine("Кофемашина загрязнена. Очистите её перед приготовлением кофе.");
                return;
            }

            CoffeeRecipe recipe = recipes.Find(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));

            if (recipe != null)
            {
                Console.WriteLine($"Приготовление {recipe.Name}...");
                if (waterAmount < recipe.WaterAmount || coffeAmound < recipe.CoffeeAmount || milkAmount < recipe.MilkAmount)
                {
                    Console.WriteLine("Недостаточно ингредиентов для приготовления.");
                    return;
                }

                waterAmount -= recipe.WaterAmount;
                coffeeAmount -= recipe.CoffeeAmount;
                milkAmount -= recipe.MilkAmount;
                MakeDirty();
                log.Add(recipeName);
                Console.WriteLine($"{recipe.Name} готов.");
            }
            else
            {
                Console.WriteLine($"Рецепт {recipeName} не найден.");
            }

        }

        public void ShowLog()
        {
        Console.WriteLine("Приготовленые чашки кофе:");
        foreach (var items in log) 
        {
            Console.WriteLine(items);
        }
         }
        public void ShowIngredients()
        {
            Console.WriteLine($"Вода: {waterAmound} мл, Кофе: {coffeeAmount} г, Молоко: {milkAmount} мл");  //!!!!!!!
        }

    }
}
