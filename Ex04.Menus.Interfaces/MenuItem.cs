namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        public string Title { get; set; }
        protected readonly IButton r_PreviousMenu;

        public MenuItem(string i_Title, IButton i_Parent)
        {
            r_PreviousMenu = i_Parent;
            Title = i_Title;
        }
    }
}
