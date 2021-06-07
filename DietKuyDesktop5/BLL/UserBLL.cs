namespace DietKuyDesktop5.BLL
{
    public abstract class UserBLL
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string LoginStatus { get; set; }
        public abstract string PrintMessage();

    }
}
