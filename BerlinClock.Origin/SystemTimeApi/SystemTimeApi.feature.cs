﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BerlinClock.SystemTimeApi
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SystemTimeApiFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SystemTimeApi.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SystemTimeApi", "In order to avoid mistakes\r\nI check if the class SystemTimeApi works correctly\r\nI" +
                    "n this feature, I check the different time events", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "SystemTimeApi")))
            {
                BerlinClock.SystemTimeApi.SystemTimeApiFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("SystemTimeApi at 00:00")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SystemTimeApi")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SystemTimeApi")]
        public virtual void SystemTimeApiAt0000()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SystemTimeApi at 00:00", new string[] {
                        "SystemTimeApi"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I implement the class SystemTimeApi and I subscribe to the event OnHourChanged", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I start the the System Timer with the hour \"0\" and the minute \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Hour",
                        "Minute"});
            table1.AddRow(new string[] {
                        "0",
                        "0"});
#line 10
 testRunner.Then("the following values for the hour and the minute are", ((string)(null)), table1, "Then ");
#line 13
 testRunner.Given("I dispose the resources the the System Timer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("SystemTimeApi at 04:10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SystemTimeApi")]
        public virtual void SystemTimeApiAt0410()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SystemTimeApi at 04:10", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given("I implement the class SystemTimeApi and I subscribe to the event OnHourChanged", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.When("I start the the System Timer with the hour \"4\" and the minute \"10\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Hour",
                        "Minute"});
            table2.AddRow(new string[] {
                        "4",
                        "10"});
#line 18
 testRunner.Then("the following values for the hour and the minute are", ((string)(null)), table2, "Then ");
#line 21
 testRunner.Given("I dispose the resources the the System Timer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("SystemTimeApi at 08:20")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SystemTimeApi")]
        public virtual void SystemTimeApiAt0820()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SystemTimeApi at 08:20", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
 testRunner.Given("I implement the class SystemTimeApi and I subscribe to the event OnHourChanged", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.When("I start the the System Timer with the hour \"8\" and the minute \"20\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Hour",
                        "Minute"});
            table3.AddRow(new string[] {
                        "8",
                        "20"});
#line 26
 testRunner.Then("the following values for the hour and the minute are", ((string)(null)), table3, "Then ");
#line 29
 testRunner.Given("I dispose the resources the the System Timer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("SystemTimeApi at 12:30")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SystemTimeApi")]
        public virtual void SystemTimeApiAt1230()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SystemTimeApi at 12:30", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("I implement the class SystemTimeApi and I subscribe to the event OnHourChanged", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.When("I start the the System Timer with the hour \"12\" and the minute \"30\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Hour",
                        "Minute"});
            table4.AddRow(new string[] {
                        "12",
                        "30"});
#line 34
 testRunner.Then("the following values for the hour and the minute are", ((string)(null)), table4, "Then ");
#line 37
 testRunner.Given("I dispose the resources the the System Timer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("SystemTimeApi at 16:40")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SystemTimeApi")]
        public virtual void SystemTimeApiAt1640()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SystemTimeApi at 16:40", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line 40
 testRunner.Given("I implement the class SystemTimeApi and I subscribe to the event OnHourChanged", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
 testRunner.When("I start the the System Timer with the hour \"16\" and the minute \"40\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Hour",
                        "Minute"});
            table5.AddRow(new string[] {
                        "16",
                        "40"});
#line 42
 testRunner.Then("the following values for the hour and the minute are", ((string)(null)), table5, "Then ");
#line 45
 testRunner.Given("I dispose the resources the the System Timer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("SystemTimeApi at 20:50")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SystemTimeApi")]
        public virtual void SystemTimeApiAt2050()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SystemTimeApi at 20:50", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
 testRunner.Given("I implement the class SystemTimeApi and I subscribe to the event OnHourChanged", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
 testRunner.When("I start the the System Timer with the hour \"20\" and the minute \"50\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Hour",
                        "Minute"});
            table6.AddRow(new string[] {
                        "20",
                        "50"});
#line 50
 testRunner.Then("the following values for the hour and the minute are", ((string)(null)), table6, "Then ");
#line 53
 testRunner.Given("I dispose the resources the the System Timer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
