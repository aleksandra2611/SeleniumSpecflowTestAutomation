using BestProjectEver.WebElements;
using OpenQA.Selenium;


namespace BestProjectEver.Pages
{
    public class EmployeeListAction : EmployeeListElement
    {
        public EmployeeListAction(IWebDriver driver) : base(driver)
        {
        }

        public void ClickEmployeeListLogin() => lnkEmployeeListLogin.Click();

        public void ClickCreateButton() => lnkCreateNew.Click();




        public bool FindName() => lnkName.Displayed;



        public void SearchElement(string name)
        {
            lnkSearchName.SendKeys(name);
            lnkSearchButton.Click();
        }

        public void ClickOnSearchButton() => lnkSearchButton.Click();


        public void ClickOnTheDeleteButton() => lnkDelete.Click();

        public void ConfrmDeleteButton() => lnkConfrmDelete.Click();


    }
}
