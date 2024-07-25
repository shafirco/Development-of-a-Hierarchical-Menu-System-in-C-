namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        public string Title { get; set; }
        protected MenuItem m_MenuListener;

        public MenuItem(string i_Title, MenuItem i_MenuListener)
        {
            Title = i_Title;
            m_MenuListener = i_MenuListener;
        }

        internal abstract void OnChoice();
    }
}
