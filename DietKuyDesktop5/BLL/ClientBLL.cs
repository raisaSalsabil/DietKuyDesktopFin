using System;

namespace DietKuyDesktop5.BLL
{
    public sealed class ClientBLL : UserBLL
    {
        //SINGLETON REFACTORING
        private static ClientBLL instance = null;
        public static ClientBLL GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new ClientBLL();
                return instance;
            }
        }
        private ClientBLL()
        {

        }
        //SINGLETON REFACTORING

        private double height;
        private double weight;
        private double bmiValue;
        private string category;
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BmiValue { get; set; }
        public string Category { get; set; }

        public double CalcBmi(double height, double weight)
        {
            this.height = height;
            this.weight = weight;
            bmiValue = weight / (height * height);
            bmiValue = Math.Round(bmiValue, 3);

            return bmiValue;
        }
        public string CategBmi(double bmiValue)
        {
            if (bmiValue < 18.5)
            {
                category = "Underweight";
            }
            else if (bmiValue >= 18.5 && bmiValue <= 24.9)
            {
                category = "Normal weight";
            }
            else if (bmiValue >= 25)
            {
                category = "Overweight";
            }
            return category;
        }
        public override string PrintMessage()
        {
            return "You are in Client Mode.. You can calculate your BMI, choose menus, and add addresses.";
        }
    }
}
