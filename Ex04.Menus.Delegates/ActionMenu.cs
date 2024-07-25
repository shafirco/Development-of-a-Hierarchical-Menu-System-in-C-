using System;

namespace Ex04.Menus.Delegates
{
    public class ActionMenu : MenuItem
    {
        public event Action ActionMethod;

        public ActionMenu(string i_Title, MenuItem i_MenuListener) : base(i_Title, i_MenuListener) { }

        internal override void OnChoice()
        {
            ActionMethod?.Invoke();
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();
        }
    }
}
