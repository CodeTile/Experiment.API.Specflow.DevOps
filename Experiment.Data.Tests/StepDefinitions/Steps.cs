using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Experiment.Data.Services;
using Experiment.Data.Tests.Models;
using TechTalk.SpecFlow.Assist;

namespace Experiment.Data.Tests.StepDefinitions
{
    public enum ContextKey
    {
        Service,
        Result,
    }

    [Binding]
    public sealed class Steps
    {
        public Steps(ScenarioContext context)
        {
            _scenarioContext = context;
        }

        private ScenarioContext _scenarioContext;

        [Given("I initiate the service ListOfCountriesService")]
        public void GivenIInitiateTheService()
        {
            _scenarioContext.Add(ContextKey.Service.ToString(), new ListOfCountriesService());
        }

        [Then(@"the result is a list with the values")]
        public void ThenTheResultIsAListWithTheValues(Table table)
        {
            var results = _scenarioContext.Get<IEnumerable<string>>(ContextKey.Result.ToString())
                         .Select(m => new ExpectedValueString() { Expected = m });

            table.CompareToSet<ExpectedValueString>(results);
        }

        [When(@"I call the method GetAllAsync")]
        public async void WhenICallTheMethodGetAllAsync()
        {
            var service = _scenarioContext.Get<ListOfCountriesService>(ContextKey.Service.ToString());
            var result = await service.GetAllAsync();

            _scenarioContext.Add(ContextKey.Result.ToString(), result);
        }
    }
}