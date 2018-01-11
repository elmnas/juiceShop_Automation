using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace JuiceShopAutomation
{
    public class LoginPage
    {
        public static void GoTo()
        {
           
            Driver.Instance.Navigate().GoToUrl("https://juice-shop.herokuapp.com/#/login");
            //var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(60));
            //wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "userEmail");
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("userEmail"));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("userPassword"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.Id("loginButton"));
            loginButton.Click();
        }
    }
}
