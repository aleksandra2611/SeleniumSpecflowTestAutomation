using BestProjectEver.Actione;
using BestProjectEver.Base;
using BestProjectEver.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BestProjectEver.StepsDefinition
{
    [Binding]
    public sealed class CreateNewEmployerSteps
    {

        EmployeeListAction employeeListAction = new EmployeeListAction(StepBase.driver);
        NewEmployeeAction newEmployeeAction = new NewEmployeeAction(StepBase.driver);




        [When(@"I click on the Employee List link")]
        public void GivenIClickOnTheEmployeeListLink()
        {

            employeeListAction.ClickEmployeeListLogin();

        }

        [When(@"I click on the Create New button")]
        public void GivenIClickOnTheCreateNewButton()
        {
            employeeListAction.ClickCreateButton();
        }

        [When(@"I fill the Employee Details")]
        public void GivenIFillTheEmployeeDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            newEmployeeAction.FillEmployerData((string)data.Name, (int)data.Salary, (int)data.DurationWorked, (int)data.Grade, (string)data.Email);

        }

        [When(@"I click on the Create Button")]
        public void GivenIClickOnTheCreateButton()
        {
            newEmployeeAction.ClickOnCreateButton();
        }


        [Then(@"I check if '(.*)' Employer Exist")]
        public void ThenICheckIfEmployerExist(string p0)
        {
            employeeListAction.FindName();

        }

        [Then(@"Employer is display")]
        public void ThenEmployerIsDisplay()
        {
            Assert.That(employeeListAction.FindName(), Is.True);

        }


    }
}
