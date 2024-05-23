class Program
{

    static void Main(string[] args)
    {
        CoffeMachine myCofe = new CoffeMachine();
        myCofe.TurnOn();
        //CoffeeRecipe latte = new CoffeeRecipe("Latte", 200,20,150);
        //CoffeeRecipe esprecsso = new CoffeeRecipe("Espresso", 50, 80,0);
        //myCofe.AddRecipe(latte);
        //myCofe.AddRecipe(esprecsso);
        myCofe.ShowRecipes();
        myCofe.TurnOff();
    }

}


public class CoffeMachine
{

    private bool isOn;
    private List<CoffeeRecipe> recipes = new List<CoffeeRecipe>
    {
        new CoffeeRecipe("Latte", 200, 20, 150), 
        new CoffeeRecipe("Espresso", 50, 80, 0) 
    };
    public CoffeMachine()
    {
        isOn = false;
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

    public void AddRecipe(CoffeeRecipe recipe)
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
}


public class CoffeeRecipe// меню рецептов 
{
    public string Name {  get; set; }
    public int WaterAmound { get; set; }
    public int CoffeAmound { get; set; }
    public int MilkAmound { get; set; }

    public CoffeeRecipe(string name, int waterAmoubd, int coffeAmound, int milkAmmound)
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




























//class Coffe
//{
//  static void Ingredients()
//    {
//        const int milkLatte = 180;
//        const int espressoLatte = 30;
//        const int espressoCofe = 30;
//        const int woterAmericano = 90;
//        const int espressoAmericano = 60;
//    }
//    public void Menu()
//    {
//       switch (true)
//        {
//            case true:
//        }   
//    }
//}