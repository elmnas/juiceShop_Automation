using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace JuiceShopAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {


            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\WebDriver\", "geckodriver.exe");
            //service.Port = 64444;
            //service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            //IWebDriver driver = new FirefoxDriver(service);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //var Instance = driver;

            Instance = new FirefoxDriver();
            
           
        }
    }
}

