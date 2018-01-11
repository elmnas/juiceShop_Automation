using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JuiceShopAutomation;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Collections.Generic;

namespace JuiceShopTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Admin_User_Can_Login()
        {
            XSS_list.userNames();

           
           // XSS_list.Passwords();
            //LoginPage.GoTo();
            //LoginPage.LoginAs("' OR 1=1-- ").WithPassword("1234").Login();       
            //Assert.IsTrue(ProductPage.IsAt, "Invalid email or password.");

            //ScoreboardPage.Find();
           //ScoreboardPage.GoTo();
           // Assert.IsTrue(ScoreboardPage.isAt, "Find all challenges");
           //comment
        }
        [TestCleanup]
        public void Clean()
            {
            Driver.Instance.Close();
            }
    }
}