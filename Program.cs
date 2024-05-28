using CoffeeMake;
using CoffeeMachine;
class Program
{

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Включить кофемашинку? \n1 On\n2 Off");
            int result = Convert.ToInt32(Console.ReadLine());
            switch (result)
            {
                case 1:
                    MainMenu.ShowMainMenu();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Некоретный ввод");
                    break;

            }   
        }
    }
}

































