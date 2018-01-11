using OpenQA.Selenium;
using System;


namespace JuiceShopAutomation
{
    public class ProductPage
    {
        public static bool IsAt
        {
            get
            {

                //Check if the WebElement and content for the element exists if not return false;
                try
                {
                    Driver.Instance.FindElement(By.XPath("//span[@translate='TITLE_LOGOUT']"));
                    Console.WriteLine("You are logged on");
                    return true;

                }
                catch (NoSuchElementException)
                {
                    Console.WriteLine("Element does not exist! or you not probably logged on");
                    return false;

                }
      
            }
        }
    }

}
