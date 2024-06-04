using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoffeeMachineLogi
{
    public  class LogiCoffee
    {
        public static List<string> historyCoking = new List<string>();

        public static void ShowCokingHistory()
        {
            Console.WriteLine("История готовки:");
            for (int i = 0; i < historyCoking.Count; i+=2)
            {
                Console.WriteLine($"Кофе: {historyCoking[i]} кол-во кружек:{historyCoking[i+1]}");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void AddHistoryCoking(string coffee, int cup)
        {
            historyCoking.Add(coffee);
            historyCoking.Add(cup.ToString());
        }
    }
  
}
