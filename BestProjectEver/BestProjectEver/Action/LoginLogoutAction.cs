using BestProjectEver.WebElements;
using OpenQA.Selenium;


namespace BestProjectEver.Pages
{
    public class LoginLogoutAction : LoginLogoutElements
    {


        public LoginLogoutAction(IWebDriver driver) : base(driver)
        {

        }

        public void ClickLogin() => lnkLogin.Click();

        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLoginButton() => btnlogin.Submit();

        public bool IsEmployeeDetailsExist() => linkEmployeeDetails.Displayed;

        public void ClickLogoutButton() => lnkLogout.Click();

        public bool IsLoginButtonIsDisplayed() => lnkLogin.Displayed;
    }
}
