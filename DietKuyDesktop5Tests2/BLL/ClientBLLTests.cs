using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietKuyDesktop5.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietKuyDesktop5.BLL.Tests
{
    [TestClass()]
    public class ClientBLLTests
    {
        [TestMethod()]
        public void CalcBmiTest()
        {
            //preparation
            ClientBLL cli = ClientBLL.GetInstance;
            double result = cli.CalcBmi(1.7, 60);

            //test
            Assert.AreEqual(20.761, result);
        }

        [TestMethod()]
        public void CategBmiTest()
        {
            //preparation
            ClientBLL cli = ClientBLL.GetInstance;
            string result = cli.CategBmi(10.0);

            Assert.AreEqual("Underweight", result);
        }
    }
}