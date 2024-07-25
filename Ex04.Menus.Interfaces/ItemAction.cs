using System;

namespace Ex04.Menus.Interfaces
{
    public class ItemAction : MenuItem, IButton
    {
        public ItemAction(string i_TitleItem, IButton i_ParentItem) : base(i_TitleItem, i_ParentItem) { }

        void IButton.pressed()
        {
            r_PreviousMenu.pressed();
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
