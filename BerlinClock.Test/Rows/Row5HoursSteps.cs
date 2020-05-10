using BerlinClock.Api.Rows;
using BerlinClock.Extensions;
using BerlinClock.Model;
using TechTalk.SpecFlow;

namespace BerlinClock.Rows
{
    [Binding]
    public class Row5HoursSteps
    {
        private IRow4Lights _row5Hours;
        private Row4LightsModel _results;

        [Given(@"I implement the first row of the Berlin clock")]
        public void GivenIImplementTheSecondRowOfTheBerlinClock()
        {
            _row5Hours = new Row5Hours();
            _row5Hours.OnRowChanged += (x) => _results = x;
        }

        [When(@"the hour for RowFiveHours is ""(.*)""")]
        public void WhenTheHourForRowFiveHoursIs(int p0)
        {
            _row5Hours.UpdateValue(p0);
        }

        [Then(@"the following values for RowFiveHours are valid")]
        public void ThenTheFollowingValuesForRowFiveHoursAreValid(Table table)
        {
            table.Rows[0].AssertLights(_results);
        }
    }
}