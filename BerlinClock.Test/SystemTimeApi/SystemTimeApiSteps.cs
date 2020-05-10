using BerlinClock.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TechTalk.SpecFlow;

namespace BerlinClock.SystemTimeApi
{
    [Binding]
    public class SystemTimeApiSteps
    {
        private ISystemTimeApi _systemTimeApi;

        private string _shortDate;
        private int _second = -1;
        private int _minute = -1;
        private int _hour = -1;

        [Given(@"I implement the class SystemTimeApi and I subscribe to the event OnHourChanged")]
        public void GivenIImplementTheClassSystemTimeApiAndISubscribeToTheEventOnHourChanged()
        {
            _systemTimeApi = new BerlinClock.Api.SystemTimeApi();
            _systemTimeApi.OnShortTimeUpdate += (x) => _shortDate = x;
            _systemTimeApi.OnSecondChanged += (x) => _second = x;
            _systemTimeApi.OnMinuteChanged += (x) => _minute = x;
            _systemTimeApi.OnHourChanged += (x) => _hour = x;
        }

        [When(@"I start the System Timer with the hour ""(.*)"" and the minute ""(.*)""")]
        public void WhenIStartTheSystemTimerWithTheHourAndTheMinute(int p0, int p1)
        {
            _systemTimeApi.Start(p0, p1);
            // We wait one second to be sure that the second has been ticked.
            Thread.Sleep(1000);
        }

        [Then(@"the following values for the hour and the minute are")]
        public void ThenTheFollowingValuesForTheHourAndTheMinuteAre(Table table)
        {
            int expectedHour = int.Parse(table.Rows[0]["Hour"]);
            int expectedMinute = int.Parse(table.Rows[0]["Minute"]);
            string expectedShortDate = $"{expectedHour.ToString("00")}:{expectedMinute.ToString("00")}";

            Assert.IsFalse(_second == -1, "The second should tick.");
            Assert.AreEqual(expectedMinute, _minute);
            Assert.AreEqual(expectedHour, _hour);
            Assert.AreEqual(expectedShortDate, _shortDate);
        }        

        [Given(@"I dispose the resources the System Timer")]
        public void GivenIDisposeTheResourcesTheTheSystemTimer()
        {
            _systemTimeApi.Dispose();
        }
    }
}