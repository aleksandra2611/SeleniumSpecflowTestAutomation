using BestProjectEver.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestProjectEver.WebElements
{
    public class NewEmployeeElements : BasePage
    {
        public NewEmployeeElements(IWebDriver webDriver) : base(webDriver)
        {
        }


        public IWebElement lnkName => Driver.FindElement(By.Id("Name"));

        public IWebElement lnkSalary => Driver.FindElement(By.Id("Salary"));

        public IWebElement lnkDurationWorked => Driver.FindElement(By.Id("DurationWorked"));

        public IWebElement lnkEmail => Driver.FindElement(By.Id("Email"));
        public IWebElement lnkGrade => Driver.FindElement(By.Id("Grade"));

        public IWebElement btnCreate => Driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[6]/div/input"));
    }
}
