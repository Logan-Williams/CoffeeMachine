using CoffeeRecipeClass;
using CoffeeMachine;
class Program
{

    static void Main(string[] args)
    {
        CoffeMachine myCofe = new CoffeMachine();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nМеню кофемашины:");
            Console.WriteLine("1. Включить кофемашину");
            Console.WriteLine("2. Выключить кофемашину");
            Console.WriteLine("3. Показать доступные рецепты");
            Console.WriteLine("4. Приготовить кофе");
            Console.WriteLine("5. Показать лог приготовленных чашек");
            Console.WriteLine("6. Показать количество ингредиентов");
            Console.WriteLine("7. Очистить кофемашину");
            Console.WriteLine("8. Выход");
            Console.Write("Выберите действие: ");

            int button = int.Parse(Console.ReadLine());

            switch (button)
            {
                case 1:
                    myCofe.TurnOn();
                    break;
                case 2:
                    myCofe.TurnOff();
                    break;
                case 3:
                    myCofe.ShowRecipes();
                    break;
                case 4:
                    Console.Write("Введите название рецепта: ");
                    string recipeName = Console.ReadLine();
                    myCofe.MakeCoffe(recipeName);
                    break;
                case 5:
                    myCofe.ShowLog();
                    break;
                case 6:
                    myCofe.ShowIngredients();
                    break;
                case 7:
                    myCofe.Clean();
                    break;
                case 8:
                    exit = true;
                    Console.WriteLine("Выход из программы...");
                    break;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                    break;
            }
        }
    }

}

































