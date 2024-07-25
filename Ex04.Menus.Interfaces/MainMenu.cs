namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private SubMenu m_MainMenu;

        internal SubMenu TheMainMenu
        {
            get { return m_MainMenu; }
        }

        public void AddItem(MenuItem i_MenuItemToAdd)
        {
            m_MainMenu.AddItem(i_MenuItemToAdd);
        }

        public MainMenu(string i_MainTitle)
        {
            m_MainMenu = new SubMenu(i_MainTitle, this);
        }

        public void Show()
        {
            (m_MainMenu as IButton).pressed();
        }
    }
}
