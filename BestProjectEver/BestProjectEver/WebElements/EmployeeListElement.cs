using BestProjectEver.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestProjectEver.WebElements
{
    public class EmployeeListElement : BasePage
    {
        public EmployeeListElement(IWebDriver webDriver) : base(webDriver)
        {

        }
        public IWebElement lnkCreateNew => Driver.FindElement(By.LinkText("Create New"));

        public IWebElement lnkEmployeeListLogin => Driver.FindElement(By.LinkText("Employee List"));

        public IWebElement lnkSearchName => Driver.FindElement(By.XPath("/html/body/div[2]/form/input[1]"));

        public IWebElement lnkSearchButton => Driver.FindElement(By.XPath("/html/body/div[2]/form/input[2]"));

        public IWebElement lnkName => Driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[1]"));

        public IWebElement lnkDelete => Driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[8]/a"));

        public IWebElement lnkConfrmDelete => Driver.FindElement(By.XPath("/html/body/div[2]/div/form/div/input"));

    }
}
