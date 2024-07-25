namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            Delegates.MainMenu menuDelegates = DelegatesMenuBuilder.BuildMenu();
            Interfaces.MainMenu menuInterfaces = InterfacesMenuBuilder.BuildMenu();
            menuDelegates.Show();
            menuInterfaces.Show();
        }
    }
}
