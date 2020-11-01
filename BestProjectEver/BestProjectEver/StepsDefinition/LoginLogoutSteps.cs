using BestProjectEver.Base;
using BestProjectEver.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BestProjectEver.StepsDefinition
{
    [Binding]
    public sealed class LoginLogoutSteps
    {
        LoginLogoutAction loginPage = null;

        [BeforeScenario]
        public static void BeforeTestRun()
        {
            StepBase.StartChromeDriver();
        }


        [AfterScenario]
        public static void AfterScenario()
        {
            StepBase.StopChromeDriver();

        }

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {

            loginPage = new LoginLogoutAction(StepBase.driver);
            loginPage.GoToPage("http://eaapp.somee.com/");

        }

        [Given(@"I Click Login link")]
        public void GivenIClickLoginLing()
        {
            loginPage.ClickLogin();
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            loginPage.Login((string)data.UserName, (string)data.Password);
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see Employee details link")]
        public void ThenIShouldSeeEmployeeDetailsLink()
        {
            Assert.That(loginPage.IsEmployeeDetailsExist(), Is.True);
        }

        [Then(@"I click on the Logout button")]
        public void ThenIClickOnTheLogoutButton()
        {
            loginPage.ClickLogoutButton();
        }

        [Then(@"I'm logged out")]
        public void ThenIMLoggedOut()
        {
            Assert.That(loginPage.IsLoginButtonIsDisplayed(), Is.True);

        }


    }
}
