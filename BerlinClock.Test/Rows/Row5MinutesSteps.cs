using BerlinClock.Api.Rows;
using BerlinClock.Extensions;
using BerlinClock.Model;
using TechTalk.SpecFlow;

namespace BerlinClock.Rows
{
    [Binding]
    public class Row5MinutesSteps
    {
        private IRow11Lights _row5Minutes;
        private Row11LightsModel _results;

        [Given(@"I implement the third row of the Berlin clock")]
        public void GivenIImplementTheThirdRowOfTheBerlinClock()
        {
            _row5Minutes = new Row5Minutes();
            _row5Minutes.OnRowChanged += (x) => _results = x;
        }
        
        [When(@"the minute for RowFiveMinutes is ""(.*)""")]
        public void WhenTheMinuteForRowFiveMinutesIs(int p0)
        {
            _row5Minutes.UpdateValue(p0);
        }
        
        [Then(@"the following values for RowFiveMinutes are valid")]
        public void ThenTheFollowingValuesForRowFiveMinutesAreValid(Table table)
        {
            table.Rows[0].AssertLights(_results);
        }
    }
}