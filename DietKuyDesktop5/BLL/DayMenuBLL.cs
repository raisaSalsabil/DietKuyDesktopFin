﻿namespace DietKuyDesktop5.BLL
{
    public sealed class DayMenuBLL : IMenu
    {
        //SINGLETON REFACTORING
        private static DayMenuBLL instance = null;
        public static DayMenuBLL GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DayMenuBLL();
                return instance;
            }
        }
        private DayMenuBLL() { }
        //SINGLETON REFACTORING

        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int ProdQty { get; set; }
        public int ProdPrice { get; set; }
        public string ProdCat { get; set; }
        public string PrintMessage()
        {
            return ("Welcome to Day Menu Manager. This page is only accessible for administrator. All field must be filled.");
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
            //Ada di DAL
        }

    }
}
