using BestProjectEver.Base;
using BestProjectEver.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BestProjectEver.StepsDefinition
{
    [Binding]
    public sealed class DeleteEmployerSteps
    {

        EmployeeListAction employeeListAction = new EmployeeListAction(StepBase.driver);

        [When(@"I deleted the Employer '(.*)'")]
        public void WhenIDeletedTheEmployer(string p0)
        {
            employeeListAction.ClickOnTheDeleteButton();
        }

        [When(@"Confrm Delete button")]
        public void WhenConfrmDeleteButton()
        {
            employeeListAction.ConfrmDeleteButton();
        }


    }
}
