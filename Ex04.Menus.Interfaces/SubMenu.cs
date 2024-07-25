using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem, IButton
    {
        private List<MenuItem> m_MenuItems = new List<MenuItem>();

        public SubMenu(string i_TitleItem, MainMenu i_ParentItem) : base(i_TitleItem, i_ParentItem.TheMainMenu) { }

        public SubMenu(string i_TitleItem, IButton i_ParentItem) : base(i_TitleItem, i_ParentItem) { }

        public void AddItem(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        public void PrintItems()
        {
            int index = 0;

            Console.Clear();
            Console.WriteLine($"**{base.Title}**");
            Console.WriteLine("--------------------------");
            foreach (MenuItem menuItem in m_MenuItems)
            {
                Console.WriteLine($"{++index} -> {menuItem.Title}");
            }

            Console.WriteLine(@"0 -> {0}", r_PreviousMenu == null ? "Exit" : "Back");
            Console.WriteLine($"Enter your request: (1 to {m_MenuItems.Count} or press '0' to Exit).");
        }

        void IButton.pressed()
        {
            string userChoiceStr;
            int userChoice;
            const int goBack = 0;

            do
            {
                PrintItems();
                userChoiceStr = Console.ReadLine();
                if (!int.TryParse(userChoiceStr, out userChoice) || userChoice < 0 || userChoice > m_MenuItems.Count)
                {
                    Console.WriteLine("Wrong input, please try again.");
                    Console.WriteLine("Press any key to continue..");
                    Console.ReadLine();
                }
                else if (userChoice != goBack)
                {
                    (m_MenuItems[userChoice - 1] as IButton).pressed();
                }
                else if (userChoice == goBack)
                {
                    return;
                }
            }
            while (true);
        }
    }
}
