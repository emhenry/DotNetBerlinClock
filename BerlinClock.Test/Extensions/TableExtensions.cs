using BerlinClock.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.Extensions
{
    public static class TableExtensions
    {
        public static void AssertLights(this Table table, Row4LightsModel row4LightsModel)
        {
            bool expectedLight1 = bool.Parse(table.Rows[0]["Light1"]);
            bool expectedLight2 = bool.Parse(table.Rows[0]["Light2"]);
            bool expectedLight3 = bool.Parse(table.Rows[0]["Light3"]);
            bool expectedLight4 = bool.Parse(table.Rows[0]["Light4"]);

            Assert.IsNotNull(row4LightsModel);

            Assert.AreEqual(expectedLight1, row4LightsModel.Light1);
            Assert.AreEqual(expectedLight2, row4LightsModel.Light2);
            Assert.AreEqual(expectedLight3, row4LightsModel.Light3);
            Assert.AreEqual(expectedLight4, row4LightsModel.Light4);
        }

        public static void AssertLights(this Table table, Row11LightsModel row11LightsModel)
        {
            bool expectedLight1 = bool.Parse(table.Rows[0]["Light1"]);
            bool expectedLight2 = bool.Parse(table.Rows[0]["Light2"]);
            bool expectedLight3 = bool.Parse(table.Rows[0]["Light3"]);
            bool expectedLight4 = bool.Parse(table.Rows[0]["Light4"]);
            bool expectedLight5 = bool.Parse(table.Rows[0]["Light5"]);
            bool expectedLight6 = bool.Parse(table.Rows[0]["Light6"]);
            bool expectedLight7 = bool.Parse(table.Rows[0]["Light7"]);
            bool expectedLight8 = bool.Parse(table.Rows[0]["Light8"]);
            bool expectedLight9 = bool.Parse(table.Rows[0]["Light9"]);
            bool expectedLight10 = bool.Parse(table.Rows[0]["Light10"]);
            bool expectedLight11 = bool.Parse(table.Rows[0]["Light11"]);
            

            Assert.IsNotNull(row11LightsModel);

            Assert.AreEqual(expectedLight1, row11LightsModel.Light1);
            Assert.AreEqual(expectedLight2, row11LightsModel.Light2);
            Assert.AreEqual(expectedLight3, row11LightsModel.Light3);
            Assert.AreEqual(expectedLight4, row11LightsModel.Light4);
            Assert.AreEqual(expectedLight5, row11LightsModel.Light5);
            Assert.AreEqual(expectedLight6, row11LightsModel.Light6);
            Assert.AreEqual(expectedLight7, row11LightsModel.Light7);
            Assert.AreEqual(expectedLight8, row11LightsModel.Light8);
            Assert.AreEqual(expectedLight9, row11LightsModel.Light9);
            Assert.AreEqual(expectedLight10, row11LightsModel.Light10);
            Assert.AreEqual(expectedLight11, row11LightsModel.Light11);            
        }
    }
}