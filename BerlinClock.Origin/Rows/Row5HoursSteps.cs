using BerlinClock.Api.Rows;
using BerlinClock.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [When(@"the hour for RowFivehours is ""(.*)""")]
        public void WhenTheHourForRowFivehoursIs(int p0)
        {
            _row5Hours.UpdateValue(p0);
        }

        [Then(@"the following values for RowFivehours are valid")]
        public void ThenTheFollowingValuesForRowFivehoursAreValid(Table table)
        {
            bool expectedLight1 = bool.Parse(table.Rows[0]["Light1"]);
            bool expectedLight2 = bool.Parse(table.Rows[0]["Light2"]);
            bool expectedLight3 = bool.Parse(table.Rows[0]["Light3"]);
            bool expectedLight4 = bool.Parse(table.Rows[0]["Light4"]);

            Assert.IsNotNull(_results);

            Assert.AreEqual(expectedLight1, _results.Light1);
            Assert.AreEqual(expectedLight2, _results.Light2);
            Assert.AreEqual(expectedLight3, _results.Light3);
            Assert.AreEqual(expectedLight4, _results.Light4);
        }
    }
}