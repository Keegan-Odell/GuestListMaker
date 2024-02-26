using ClassLibrary.Enums;
using ClassLibrary.Models;

namespace ClassLibrary.Methods
{
    public class AddGuestMethod
    {
        public static List<GuestModel> AddGuestToList(List<GuestModel> partyList)
        {
            Phase1ConsoleChatter();
            string name = AskName();
            Phase2ConsoleChatter();
            int age = AskAge();
            Phase3ConsoleChatter();
            SteakOrChicken meal = AskMeal();

            if (age != 0 && meal != SteakOrChicken.Other)
            {
                GuestModel guest = CreateGuest(name, age, meal);
                partyList.Add(guest);
            }
            else if (age == 0 && meal != SteakOrChicken.Other)
            {
                GuestModel guest = CreateGuest(name, meal);

                partyList.Add(guest);
            }
            else
            {
                GuestModel guest = CreateGuest(name, age);

                partyList.Add(guest);
            }

            return partyList;
        }

        private static GuestModel CreateGuest(string name, int age, SteakOrChicken meal)
        {
            GuestModel guest = new()
            {
                Name = name,
                Age = age,
                Meal = meal
            };

            return guest;
        }

        private static GuestModel CreateGuest(string name, SteakOrChicken meal)
        {
            GuestModel guest = new()
            {
                Name = name,
                Age = 0,
                Meal = meal
            };

            return guest;
        }

        private static GuestModel CreateGuest(string name, int age)
        {
            GuestModel guest = new()
            {
                Name = name,
                Age = age,
                Meal = SteakOrChicken.Other
            };

            return guest;
        }

        private static void Phase1ConsoleChatter()
        {
            Console.WriteLine("PLease enter the information of your Guest!");
            Console.WriteLine("What is the Name of the guest?: ");
        }

        private static void Phase2ConsoleChatter()
        {
            Console.WriteLine();

            Console.WriteLine("What is your age? (enter 0 if unknown): ");
        }

        private static void Phase3ConsoleChatter()
        {
            Console.WriteLine();

            Console.WriteLine("Would the guest like either steak or chicken?");
        }

        private static string AskName()
        {
            string? name;

            do
            {
                name = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(name));

            return name;
        }

        private static int AskAge()
        {
            int age;

            bool check;

            do
            {
                string? ageStr = Console.ReadLine();

               check = int.TryParse(ageStr, out age);

            } while (!check);

            return age;
        }

        private static SteakOrChicken AskMeal()
        {
            string? meal;

            do
            {
                meal = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(meal));

            if (meal.ToLower() == "steak")
            {
                return SteakOrChicken.Steak;
            }
            if (meal.ToLower() == "chicken")
            {
                return SteakOrChicken.Chicken;
            }

            return SteakOrChicken.Other;
        }
    }
}
