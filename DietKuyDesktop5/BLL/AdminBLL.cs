namespace DietKuyDesktop5.BLL
{
    public sealed class AdminBLL : UserBLL
    {
        //SINGLETON REFACTORING
        private static AdminBLL instance = null;
        public static AdminBLL GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new AdminBLL();
                return instance;
            }
        }
        private AdminBLL()
        {

        }
        //SINGLETON REFACTORING

        public void ManageDayMenu()
        {
            //ada di form Manage Day Menu
        }
        public void ManageNightMneu()
        {
            //ada di form Manage Night Menu
        }
        public override string PrintMessage()
        {
            return "You are in Admin Mode.. You can manage day and night menu list. Freely add new menus and their descriptions.";
        }
    }
}
