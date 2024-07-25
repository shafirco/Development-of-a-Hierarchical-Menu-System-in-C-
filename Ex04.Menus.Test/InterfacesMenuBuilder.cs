using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : IButton
    {
        void IButton.pressed()
        {
            Console.WriteLine($"The date is: {DateTime.Now.ToShortDateString()}");
        }
    }

    public class ShowTime : IButton
    {
        void IButton.pressed()
        {
            Console.WriteLine($"The time is: {DateTime.Now.ToLongTimeString()}");
        }
    }

    public class CountCapitals : IButton
    {
        void IButton.pressed()
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
    }

    public class ShowVersion : IButton
    {
        void IButton.pressed()
        {
            Console.WriteLine("Version: 23.2.4.9805");
        }
    }

    public class InterfacesMenuBuilder
    {
        public static MainMenu BuildMenu()
        {
            MainMenu mainMenu = new MainMenu("Interfaces Main Menu");

            SubMenu showDateOrTime = new SubMenu("Show Date/Time", mainMenu);
            mainMenu.AddItem(showDateOrTime);

            SubMenu versionAndCapitals = new SubMenu("Version and Capitals", mainMenu);
            mainMenu.AddItem(versionAndCapitals);

            ItemAction showDate = new ItemAction("Show Date", new ShowDate());
            showDateOrTime.AddItem(showDate);

            ItemAction showTime = new ItemAction("Show Time", new ShowTime());
            showDateOrTime.AddItem(showTime);

            ItemAction showVersion = new ItemAction("Show Version", new ShowVersion());
            versionAndCapitals.AddItem(showVersion);

            ItemAction countCapitals = new ItemAction("Count Capitals", new CountCapitals());
            versionAndCapitals.AddItem(countCapitals);

            return mainMenu;
        }
    }
}
