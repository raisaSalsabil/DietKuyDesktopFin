namespace DietKuyDesktop5.BLL
{
    interface IMenu
    {
        int ProdId { get; set; }
        string ProdName { get; set; }
        int ProdQty { get; set; }
        int ProdPrice { get; set; }
        string ProdCat { get; set; }
        string PrintMessage();
        void InsertMenu();

        void UpdateMenu();
        void DeleteMenu();
        void ShowMenu();
    }
}
