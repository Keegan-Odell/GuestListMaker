
using ClassLibrary.Methods;
using ClassLibrary.Models;
using GuestList;

//Welcome message and explanation of app
ConsoleChatter.WelcomeMessages.WelcomeMessage();
ConsoleChatter.EnterToContinue.WriteEnterToContinue();
ConsoleChatter.WelcomeMessages.ExplanationOfApp();
ConsoleChatter.EnterToContinue.WriteEnterToContinue();

bool breakCondition = true;

while (breakCondition)
{
    breakCondition = ConsoleChatter.MenuSelection.Selector();
}

internal class ConsoleChatter
{
    internal static class WelcomeMessages
    {
        internal static void WelcomeMessage()
        {
            Console.WriteLine("Hello and welcome to the GuestBook planning app");
        }

        internal static void ExplanationOfApp()
        {
            Console.WriteLine("This app will help you enter in all you need to know for your upcoming event.");
            Console.WriteLine("The app will ask for the guest's name, age, and meal preference.");
            Console.WriteLine("Just include a name and all information you know and we will take care of the rest.");
            Console.WriteLine("When you are finished check your list and then export it to a .txt file for easy planning!");
        }
    }

    internal static class EnterToContinue
    {
        internal static void WriteEnterToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }

    internal static class MainMenu
    {
        internal static string WriteMenu()
        {
            List<string> menuStatements = ["Add Guest", "Display Guests", "Export Guest List", "Exit"];
            int index = 1;
            Console.WriteLine("Main Menu");
            foreach (string str in menuStatements)
            {
                Console.WriteLine($"    {index}. {str}");
                index++;
            }

            Console.WriteLine();
            Console.WriteLine("Please enter the menu number to continue!");
            string? menuSelection = Console.ReadLine();
            //while loop for selection
            while (menuSelection != "1" && menuSelection != "2" && menuSelection != "3" && menuSelection != "4")
            {
                Console.WriteLine("bad entry");
                menuSelection = Console.ReadLine();
            }

            return menuSelection;
        }
    }

    internal static class MenuSelection
    {
        internal static bool Selector()
        {
            bool continueLoop = true;

            while (continueLoop)
            {
                string selection = MainMenu.WriteMenu();

                switch (selection)
                {
                    case "1":
                        AddGuestMethod.AddGuestToList(GlobalData.PartyList);
                        break;
                    case "2":
                        ListGuestMethod.ListGuests(GlobalData.PartyList);
                        break;
                    case "3":
                        WriteTxtFileMethod.exportPartyList(GlobalData.PartyList);
                        break;
                    default:
                        continueLoop = false;
                        break;
                }
            }

            return false;
        }

    }
}