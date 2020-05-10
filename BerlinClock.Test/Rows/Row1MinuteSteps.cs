using BerlinClock.Api.Rows;
using BerlinClock.Extensions;
using BerlinClock.Model;
using TechTalk.SpecFlow;

namespace BerlinClock.Rows
{
    [Binding]
    public class Row1MinuteSteps
    {
        private IRow4Lights _row1Minute;
        private Row4LightsModel _results;

        [Given(@"I implement the fourth row of the Berlin clock")]
        public void GivenIImplementTheFourthRowOfTheBerlinClock()
        {
            _row1Minute = new Row1Minute();
            _row1Minute.OnRowChanged += (x) => _results = x;
        }
        
        [When(@"the minute for RowOneMinute is ""(.*)""")]
        public void WhenTheMinuteForRowOneMinuteIs(int p0)
        {
            _row1Minute.UpdateValue(p0);
        }
        
        [Then(@"the following values for RowOneMinute are valid")]
        public void ThenTheFollowingValuesForRowOneMinuteAreValid(Table table)
        {
            table.Rows[0].AssertLights(_results);
        }
    }
}