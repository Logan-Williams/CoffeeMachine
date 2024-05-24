using System;
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

    public void MakeCoffe(string recipeName)
    {
        if (!isOn)
        {
            Console.WriteLine("Кофемашинка выключена, включите ее для испоьзования");
            return;
        }
        if (isDirty)
        {
            Console.WriteLine("Кофемашинка загрязнена. Очистите её для приготовления кофе");
            return;
        }
        CoffeeRecipeClass.CoffeeRecipeClass recipe = recipes.Find(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase)); // Equals(Object, Object) Определяет, считаются ли равными указанные экземпляры объектов.

            // r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase)
            // — это условие, проверяющее, равняется ли имя рецепта Name у текущего элемента r значению recipeName,
            // при этом игнорируется регистр символов благодаря использованию StringComparison.OrdinalIgnoreCase

            if (recipe != null)
        {
            Console.WriteLine($"Приготовление {recipe.Name}");
            MakeDirty();
            log.Add(recipeName);
            Console.WriteLine($"{recipe.Name} готов.");
        }
       else
        {
            Console.WriteLine($"Рецепт {recipe.Name} не найден.");
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

 }
}
