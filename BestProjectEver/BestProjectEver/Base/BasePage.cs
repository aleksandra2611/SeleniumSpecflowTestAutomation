using OpenQA.Selenium;
using System;


namespace BestProjectEver.Base
{
    public class BasePage
    {
        public IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }


        public void GoToPage(String url)
        {
            Driver.Navigate().GoToUrl(url);
        }
    }
}
