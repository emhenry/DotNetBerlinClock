using BerlinClock.Api.Rows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.Rows
{
    [Binding]
    public class Row1HourSteps
    {
        private IRow4Lights _row1Hour;
        private Model.Row4LightsModel _results;

        [Given(@"I implement the second row of the Berlin clock")]
        public void GivenIImplementTheSecondRowOfTheBerlinClock()
        {
            _row1Hour = new Row1Hour();
            _row1Hour.OnRowChanged += (x) => _results = x;
        }

        [When(@"the hour for RowOnehours is ""(.*)""")]
        public void WhenTheHourForRowOnehoursIs(int p0)
        {
            _row1Hour.UpdateValue(p0);
        }

        [Then(@"the following values for RowOnehours are valid")]
        public void ThenTheFollowingValuesForRowOnehoursAreValid(Table table)
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