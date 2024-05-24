using CoffeeRecipeClass;
using CoffeeMachine;
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

        myCofe.MakeCoffe("Latte");
        myCofe.MakeCoffe("Esresso");

        myCofe.ShowLog();

        myCofe.TurnOff();
    }

}

































