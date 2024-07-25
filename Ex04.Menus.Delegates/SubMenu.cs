using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private List<MenuItem> m_MenuItems = new List<MenuItem>();

        public SubMenu(string i_Title, MenuItem i_MenuListener) : base(i_Title, i_MenuListener) { }

        internal override void OnChoice()
        {
            bool goodInput = true;
            string userChoiceStr;
            int userChoice;
            const int goBack = 0;

            do
            {
                showSubMenu();
                userChoiceStr = Console.ReadLine();
                if (!int.TryParse(userChoiceStr, out userChoice) || userChoice < goBack || userChoice > m_MenuItems.Count)
                {
                    Console.WriteLine("Wrong input, please try again.");
                    Console.WriteLine("Press any key to continue..");
                    Console.ReadLine();
                }

                if (userChoice > goBack && userChoice <= m_MenuItems.Count)
                {
                    m_MenuItems[userChoice - 1].OnChoice();
                }
                else if (userChoice == goBack)
                {
                    return;
                }
            } while (true);
        }

        private void showSubMenu()
        {
            int index = 0;

            Console.Clear();
            Console.WriteLine($"**{base.Title}**");
            Console.WriteLine("--------------------------");
            foreach (MenuItem item in m_MenuItems)
            {
                Console.WriteLine($"{++index} -> {item.Title}");
            }

            Console.WriteLine(@"0 -> {0}", base.m_MenuListener == null ? "Exit" : "Back");
            Console.WriteLine($"Enter your request: (1 to {m_MenuItems.Count} or press '0' to Exit).");
        }

        public void AddMenuItem(MenuItem i_MenuToAdd)
        {
            m_MenuItems.Add(i_MenuToAdd);
        }
    }
}
