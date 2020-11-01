using BestProjectEver.Base;
using OpenQA.Selenium;

namespace BestProjectEver.WebElements
{
    public class LoginLogoutElements : BasePage
    {



        public LoginLogoutElements(IWebDriver webDriver) : base(webDriver)
        {
        }
        //UI elements
        public IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        public IWebElement lnkLogout => Driver.FindElement(By.LinkText("Log off"));

        public IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));

        public IWebElement txtPassword => Driver.FindElement(By.Name("Password"));

        public IWebElement btnlogin => Driver.FindElement(By.CssSelector(".btn-default"));

        public IWebElement linkEmployeeDetails => Driver.FindElement(By.LinkText("Employee Details"));

        public IWebElement linkCreate => Driver.FindElement(By.ClassName("btn btn-default"));

    }
}
