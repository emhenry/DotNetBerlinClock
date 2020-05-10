using BerlinClock.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.Extensions
{
    public static class TableExtensions
    {
        private const string _errorMessage = "The light '{0}' should be '{1}' instead of '{2}'.";
        /// <summary>
        /// Assert the expected data table with a result of 4 lights row.
        /// </summary>
        /// <param name="tableRow">Expected data row</param>
        /// <param name="row4LightsModel">Result of 4 lights row</param>
        public static void AssertLights(this TableRow tableRow, Row4LightsModel row4LightsModel)
        {
            bool expectedLight1 = bool.Parse(tableRow["Light1"]);
            bool expectedLight2 = bool.Parse(tableRow["Light2"]);
            bool expectedLight3 = bool.Parse(tableRow["Light3"]);
            bool expectedLight4 = bool.Parse(tableRow["Light4"]);

            Assert.IsNotNull(row4LightsModel, "The 4 lights model should be not null.");

            Assert.AreEqual(expectedLight1, row4LightsModel.Light1, string.Format(_errorMessage, 1, expectedLight1, row4LightsModel.Light1));
            Assert.AreEqual(expectedLight2, row4LightsModel.Light2, string.Format(_errorMessage, 2, expectedLight2, row4LightsModel.Light2));
            Assert.AreEqual(expectedLight3, row4LightsModel.Light3, string.Format(_errorMessage, 3, expectedLight3, row4LightsModel.Light3));
            Assert.AreEqual(expectedLight4, row4LightsModel.Light4, string.Format(_errorMessage, 4, expectedLight4, row4LightsModel.Light4));
        }

        /// <summary>
        /// Assert the expected data table with a result of 11 lights row.
        /// </summary>
        /// <param name="tableRow">Expected data row</param>
        /// <param name="row11LightsModel">Result of 11 lights row</param>
        public static void AssertLights(this TableRow tableRow, Row11LightsModel row11LightsModel)
        {
            bool expectedLight1 = bool.Parse(tableRow["Light1"]);
            bool expectedLight2 = bool.Parse(tableRow["Light2"]);
            bool expectedLight3 = bool.Parse(tableRow["Light3"]);
            bool expectedLight4 = bool.Parse(tableRow["Light4"]);
            bool expectedLight5 = bool.Parse(tableRow["Light5"]);
            bool expectedLight6 = bool.Parse(tableRow["Light6"]);
            bool expectedLight7 = bool.Parse(tableRow["Light7"]);
            bool expectedLight8 = bool.Parse(tableRow["Light8"]);
            bool expectedLight9 = bool.Parse(tableRow["Light9"]);
            bool expectedLight10 = bool.Parse(tableRow["Light10"]);
            bool expectedLight11 = bool.Parse(tableRow["Light11"]);
            

            Assert.IsNotNull(row11LightsModel, "The 11 lights model should be not null.");

            Assert.AreEqual(expectedLight1, row11LightsModel.Light1, string.Format(_errorMessage, 1, expectedLight1, row11LightsModel.Light1));
            Assert.AreEqual(expectedLight2, row11LightsModel.Light2, string.Format(_errorMessage, 2, expectedLight2, row11LightsModel.Light2));
            Assert.AreEqual(expectedLight3, row11LightsModel.Light3, string.Format(_errorMessage, 3, expectedLight3, row11LightsModel.Light3));
            Assert.AreEqual(expectedLight4, row11LightsModel.Light4, string.Format(_errorMessage, 4, expectedLight4, row11LightsModel.Light4));
            Assert.AreEqual(expectedLight5, row11LightsModel.Light5, string.Format(_errorMessage, 5, expectedLight5, row11LightsModel.Light5));
            Assert.AreEqual(expectedLight6, row11LightsModel.Light6, string.Format(_errorMessage, 6, expectedLight6, row11LightsModel.Light6));
            Assert.AreEqual(expectedLight7, row11LightsModel.Light7, string.Format(_errorMessage, 7, expectedLight7, row11LightsModel.Light7));
            Assert.AreEqual(expectedLight8, row11LightsModel.Light8, string.Format(_errorMessage, 8, expectedLight8, row11LightsModel.Light8));
            Assert.AreEqual(expectedLight9, row11LightsModel.Light9, string.Format(_errorMessage, 9, expectedLight9, row11LightsModel.Light9));
            Assert.AreEqual(expectedLight10, row11LightsModel.Light10, string.Format(_errorMessage, 10, expectedLight10, row11LightsModel.Light10));
            Assert.AreEqual(expectedLight11, row11LightsModel.Light11, string.Format(_errorMessage, 11, expectedLight11, row11LightsModel.Light11));            
        }
    }
}