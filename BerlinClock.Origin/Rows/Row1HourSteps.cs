using BerlinClock.Api.Rows;
using BerlinClock.Extensions;
using BerlinClock.Model;
using TechTalk.SpecFlow;

namespace BerlinClock.Rows
{
    [Binding]
    public class Row1HourSteps
    {
        private IRow4Lights _row1Hour;
        private Row4LightsModel _results;

        [Given(@"I implement the second row of the Berlin clock")]
        public void GivenIImplementTheSecondRowOfTheBerlinClock()
        {
            _row1Hour = new Row1Hour();
            _row1Hour.OnRowChanged += (x) => _results = x;
        }

        [When(@"the hour for RowOneHour is ""(.*)""")]
        public void WhenTheHourForRowOneHourIs(int p0)
        {
            _row1Hour.UpdateValue(p0);
        }

        [Then(@"the following values for RowOneHour are valid")]
        public void ThenTheFollowingValuesForRowOneHourAreValid(Table table)
        {
            table.AssertLights(_results);
        }
    }
}