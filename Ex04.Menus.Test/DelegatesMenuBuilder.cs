using System;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegatesMenuBuilder
    {
        public static MainMenu BuildMenu()
        {
            MainMenu mainMenu = new MainMenu("Delegates Main Menu");

            SubMenu showDateOrTime = new SubMenu("Show Date/Time", mainMenu.RootMenu);
            mainMenu.AddMenuItem(showDateOrTime);
            SubMenu versionAndCapitals = new SubMenu("Version and Capitals", mainMenu.RootMenu);
            mainMenu.AddMenuItem(versionAndCapitals);

            ActionMenu showDate = new ActionMenu("Show Date", showDateOrTime);
            showDate.ActionMethod += ShowDate_ActionMethod;
            showDateOrTime.AddMenuItem(showDate);
            ActionMenu showTime = new ActionMenu("Show Time", showDateOrTime);
            showTime.ActionMethod += ShowTime_ActionMethod;
            showDateOrTime.AddMenuItem(showTime);

            ActionMenu showVersion = new ActionMenu("Show Version", versionAndCapitals);
            showVersion.ActionMethod += ShowVersion_ActionMethod;
            versionAndCapitals.AddMenuItem(showVersion);
            ActionMenu countCapitals = new ActionMenu("Count Capitals", versionAndCapitals);
            countCapitals.ActionMethod += CountCapitals_ActionMethod;
            versionAndCapitals.AddMenuItem(countCapitals);

            return mainMenu;
        }

        private static void CountCapitals_ActionMethod()
        {
            string sentence;
            int countCapitals = 0;

            Console.Write("Please enter your sentence: ");
            sentence = Console.ReadLine();
            foreach (char c in sentence)
            {
                if (char.IsUpper(c))
                {
                    countCapitals++;
                }
            }

            Console.WriteLine($"There are {countCapitals} capitals in your sentence.");
        }

        private static void ShowVersion_ActionMethod()
        {
            Console.WriteLine("Version: 23.2.4.9805");
        }

        private static void ShowTime_ActionMethod()
        {
            Console.WriteLine($"The time is: {DateTime.Now.ToLongTimeString()}");
        }

        private static void ShowDate_ActionMethod()
        {
            Console.WriteLine($"The date is: {DateTime.Now.ToShortDateString()}");
        }
    }
}

