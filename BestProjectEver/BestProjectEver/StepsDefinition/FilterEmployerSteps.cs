using BestProjectEver.Base;
using BestProjectEver.Pages;
using TechTalk.SpecFlow;

namespace BestProjectEver.StepsDefinition
{
    [Binding]
    public sealed class FilterEmployerSteps
    {

        EmployeeListAction employeeListAction = new EmployeeListAction(StepBase.driver);


        [When(@"I Searche '(.*)' Employer")]
        public void WhenIFiltEmployer(string p0)
        {
            employeeListAction.SearchElement(p0);
        }

    }
}
