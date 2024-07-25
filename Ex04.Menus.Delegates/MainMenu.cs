namespace Ex04.Menus.Delegates
{
    public class MainMenu 
    {
        private SubMenu m_RootMenu;

        public MainMenu(string i_Title)
        {
            m_RootMenu = new SubMenu(i_Title, m_RootMenu);
        }

        public SubMenu RootMenu { get { return m_RootMenu; } }

        public void Show()
        {
            m_RootMenu.OnChoice();
        }

        public void AddMenuItem(MenuItem i_MenuToAdd)
        {
            m_RootMenu.AddMenuItem(i_MenuToAdd);
        }
    }
}