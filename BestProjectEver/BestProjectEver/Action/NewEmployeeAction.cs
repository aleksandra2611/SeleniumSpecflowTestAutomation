using BestProjectEver.WebElements;
using OpenQA.Selenium;
using System;


namespace BestProjectEver.Actione
{
    class NewEmployeeAction : NewEmployeeElements
    {
        public NewEmployeeAction(IWebDriver driver) : base(driver)
        {
        }



        public void FillEmployerData(string name, int salary, int durationWorked, int grade, string email)
        {
            lnkName.SendKeys(name);
            lnkSalary.SendKeys(Convert.ToString(salary));
            lnkDurationWorked.SendKeys(Convert.ToString(durationWorked));
            lnkGrade.SendKeys(Convert.ToString(grade));
            lnkEmail.SendKeys(email);
        }

        public void ClickOnCreateButton() => btnCreate.Click();
    }
}
