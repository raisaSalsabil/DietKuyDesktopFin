namespace DietKuyDesktop5.BLL
{
    public sealed class DeliveryBLL
    {
        //SINGLETON REFACTORING
        private static DeliveryBLL instance = null;
        public static DeliveryBLL GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DeliveryBLL();
                return instance;
            }
        }
        private DeliveryBLL() { }
        //SINGLETON REFACTORING

        public int DeliId { get; set; }
        public string DeliName { get; set; }
        public string DeliPhone { get; set; }
        public string DeliAddress { get; set; }
        public string DeliDesc { get; set; }
    }
}
