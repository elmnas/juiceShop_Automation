using JuiceShopAutomation;
using OpenQA.Selenium;
using System;

namespace JuiceShopTests
{
    public class ScoreboardPage
    {

        public static void Find()
        {
            Driver.Instance.Navigate().GoToUrl("https://juice-shop.herokuapp.com/#/");

            try
            {
                Driver.Instance.PageSource.Contains("#/score-board");
                Console.WriteLine(Driver.Instance.PageSource.Contains("#/score-board"));
            }
            catch
            {
                
            }

        }



        public static void GoTo()
        {
            throw new NotImplementedException();
        }


        public static bool isAt
        {
            get
            {
                try
                {
                    Driver.Instance.FindElement(By.XPath("//span[@translate='TITLE_LOGOUT']"));
                    Console.WriteLine("Scoreboard found");
                    return true;
                }
                catch (NoSuchElementException)
                {

                    Driver.Instance.FindElement(By.XPath("//span[@translate='TITLE_LOGOUT']"));
                    Console.WriteLine("Scoreboard not found");
                    return false;

                }

            }
        }
    }



}