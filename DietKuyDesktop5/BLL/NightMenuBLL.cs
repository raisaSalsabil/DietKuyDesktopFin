namespace DietKuyDesktop5.BLL
{
    public sealed class NightMenuBLL : IMenu
    {
        //SINGLETON REFACTORING
        private static NightMenuBLL instance = null;
        public static NightMenuBLL GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new NightMenuBLL();
                return instance;
            }
        }
        private NightMenuBLL() { }
        //SINGLETON REFACTORING

        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int ProdQty { get; set; }
        public int ProdPrice { get; set; }
        public string ProdCat { get; set; }
        public string ProdSize { get; set; }
        public string ProdExtra { get; set; }
        public string PrintMessage()
        {
            return ("Welcome to Night Menu Manager. This page is only accessible for administrator. All field must be filled. For night menu, various size and extra service is available.");
        }
        public void InsertMenu()
        {
            //Ada di DAL
        }
        public void UpdateMenu()
        {
            //Ada di DAL
        }
        public void DeleteMenu()
        {
            //Ada di DAL
        }
        public void ShowMenu()
        {
            //Ada di
        }
    }
}
