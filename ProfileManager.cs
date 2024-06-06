using CoffeeMachineLogi;
using System;
using CoffeeMake;
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

    public  class ProfileManager
    {
        static List<Profile> ProfileList = new List<Profile>();

        public static void CreateProfile(string profileName, int water, int coffee, int milk, int cup)
        {
            ProfileList.Add(new Profile(profileName, water, coffee, milk, cup));
            Console.WriteLine($"Профиль {profileName} успешно создан");
            Console.ReadKey();
            Console.Clear();
        }
        public static void InputCreateProfile() 
        {
            Console.WriteLine("Название профиля");
            string profileName = Console.ReadLine();
            try
            {
                if (profileName == "") 
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Имя профиля не может быть пустым");
                InputCreateProfile();
                throw;
            }
            Console.WriteLine("Введите количество воды");
            int water = MainMenu.GetUserPrint();
            if (water >= 1000)
            {
                Console.WriteLine("Привышен лимит, максимально 1000 мл воды");
                Console.ReadKey();
                Console.Clear();
                InputCreateProfile();
            }
            Console.WriteLine("Введите количество кофе");
            int coffee = MainMenu.GetUserPrint();
            if (coffee >= 300)
            {
                Console.WriteLine("Привышен лимит, максимально 300 мл кофе");
                Console.ReadKey();
                Console.Clear();
                InputCreateProfile();
            }
            Console.WriteLine("Введите количество молока");
            int milk = MainMenu.GetUserPrint();
            if (milk >= 900)
            {
                Console.WriteLine("Привышен лимит, максимально 900 мл молока");
                Console.ReadKey();
                Console.Clear();
                InputCreateProfile();
            }
            Console.WriteLine("Введите количество кружек");
            int cup = MainMenu.GetUserPrint();
            if (!Coffee.CheckIngredient(water*cup, milk*cup, coffee*cup))
            {
                Console.WriteLine("Профиль невалиден");
                Console.ReadKey();
                Console.Clear();
                InputCreateProfile();
            }
            CreateProfile(profileName, water, coffee, milk, cup);


        }
        public static void ViewProfile()
        {
            if (ProfileList.Count == 0)
            {
                Console.WriteLine("Профилей не сущесвует");
            }
            else
            {
                foreach (var profile in ProfileList)
                {
                    Console.WriteLine($"Имя профиля: {profile.Name} Воды: {profile.Water} Кофе: {profile.Coffee} Молока: {profile.Milk} Кружек: {profile.Cup} ");
                }
            }
        }
        public static void ProfeleSearch(string name) 
        {
            foreach (var profile in ProfileList)
            {
                if (profile.Name == name)
                {

                }
                else 
                {
                    Console.WriteLine("Профиль не найден");
                }
            }
        }
        public static void MackeProfileCoffee(Profile profile)
        { 

        }

        
    }
    public class MenuManager
    {
        public static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Приготовить по профилю");
                Console.WriteLine("2. Создать профиль");
                Console.WriteLine("3. Назад");

                int result = MainMenu.GetUserPrint();
                switch (result)
                {
                    case 1:
                        
                        break;
                    case 2:
                        Console.Clear();
                        ProfileManager.InputCreateProfile();
                        break;
                    case 3:
                        Console.Clear();
                        MainMenu.ShowMainMenu();
                        break;
                }
            }
           
            
             
        }
    }


}
