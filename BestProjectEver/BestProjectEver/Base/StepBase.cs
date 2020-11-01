using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BestProjectEver.Base
{
    public static class StepBase
    {
        public static IWebDriver driver;

        public static void StartChromeDriver()
        {
            driver = new ChromeDriver();
        }

        public static void StopChromeDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
