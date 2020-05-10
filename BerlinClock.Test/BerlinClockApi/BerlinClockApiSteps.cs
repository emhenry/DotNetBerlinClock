using BerlinClock.Api;
using BerlinClock.Api.Rows;
using BerlinClock.Extensions;
using BerlinClock.Model;
using System.Threading;
using TechTalk.SpecFlow;

namespace BerlinClock.BerlinClockApi
{
    [Binding]
    public class BerlinClockApiSteps
    {
        private IBerlinClockApi _berlinClockApi;
        private Row4LightsModel _row5Hours;
        private Row4LightsModel _row1Hour;
        private Row11LightsModel _row5Minutes;
        private Row4LightsModel _row1Minute;

        [Given(@"I implement the class BerlinClockApi")]
        public void GivenIImplementTheClassBerlinClockApi()
        {
            _berlinClockApi = new BerlinClock.Api.BerlinClockApi(
                                new Row5Hours(), new Row1Hour(),
                                new Row5Minutes(), new Row1Minute(), 
                                new BerlinClock.Api.SystemTimeApi());            
        }

        [Given(@"I subscribe to the row events")]
        public void GivenISubscribeToTheRowEvents()
        {
            _berlinClockApi.OnRow5HoursChanged += (x) => _row5Hours = x;
            _berlinClockApi.OnRow1HourChanged += (x) => _row1Hour = x;
            _berlinClockApi.OnRow5MinutesChanged += (x) => _row5Minutes = x;
            _berlinClockApi.OnRow1MinuteChanged += (x) => _row1Minute = x;
        }

        [When(@"I start the the the Berlin clock with the hour ""(.*)"" and the minute ""(.*)""")]
        public void WhenIStartTheTheTheBerlinClockWithTheHourAndTheMinute(int p0, int p1)
        {
            _berlinClockApi.Start(p0, p1);
            // We wait one second to be sure that all the events has been triggered.
            Thread.Sleep(1000);
        }

        [Then(@"the following lights on for the Berlin clock are")]
        public void ThenTheFollowingLightsOnForTheBerlinClockAre(Table table)
        {
            table.Rows[0].AssertLights(_row5Hours);
            table.Rows[1].AssertLights(_row1Hour);
            table.Rows[2].AssertLights(_row5Minutes);
            table.Rows[3].AssertLights(_row1Minute);
        }

        [Given(@"I dispose the resources the BerlinClockApi")]
        public void GivenIDisposeTheResourcesTheBerlinClockApi()
        {
            _berlinClockApi.Dispose();
        }
    }
}