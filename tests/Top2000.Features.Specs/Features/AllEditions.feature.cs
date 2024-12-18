﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Top2000.Features.Specs.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AllEditionsFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "All Editions", null, global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "AllEditions.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute(Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupBehavior.EndOfClass)]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The first edition of the Top2000 was in 1999")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "All Editions")]
        public async System.Threading.Tasks.Task TheFirstEditionOfTheTop2000WasIn1999()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("The first edition of the Top2000 was in 1999", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 4
await testRunner.GivenAsync("All data scripts", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 5
await testRunner.WhenAsync("the feature is executed", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 6
await testRunner.ThenAsync("the latest year is 1999", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Every edition is returned starting with the highest year")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "All Editions")]
        public async System.Threading.Tasks.Task EveryEditionIsReturnedStartingWithTheHighestYear()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Every edition is returned starting with the highest year", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 9
await testRunner.GivenAsync("All data scripts", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 10
await testRunner.WhenAsync("the feature is executed", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 11
await testRunner.ThenAsync("a sorted set is returned started with the highest year", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("An Edition contains the datetime in local time")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "All Editions")]
        public async System.Threading.Tasks.Task AnEditionContainsTheDatetimeInLocalTime()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("An Edition contains the datetime in local time", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 14
await testRunner.GivenAsync("All data scripts", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 15
await testRunner.WhenAsync("the feature is executed", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 16
await testRunner.ThenAsync("the Start- and EndDateTime is in local time", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The first editions started at the start of boxing day (CET)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "All Editions")]
        public async System.Threading.Tasks.Task TheFirstEditionsStartedAtTheStartOfBoxingDayCET()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("The first editions started at the start of boxing day (CET)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 19
await testRunner.GivenAsync("All data scripts", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 20
await testRunner.WhenAsync("the feature is executed", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
                global::Reqnroll.Table table1 = new global::Reqnroll.Table(new string[] {
                            "Year",
                            "UTC Startdate"});
                table1.AddRow(new string[] {
                            "1999",
                            "1999-12-25T23:00:00"});
                table1.AddRow(new string[] {
                            "2001",
                            "2001-12-25T23:00:00"});
                table1.AddRow(new string[] {
                            "2002",
                            "2002-12-25T23:00:00"});
                table1.AddRow(new string[] {
                            "2003",
                            "2003-12-25T23:00:00"});
                table1.AddRow(new string[] {
                            "2004",
                            "2004-12-25T23:00:00"});
                table1.AddRow(new string[] {
                            "2005",
                            "2005-12-25T23:00:00"});
                table1.AddRow(new string[] {
                            "2006",
                            "2006-12-25T23:00:00"});
                table1.AddRow(new string[] {
                            "2007",
                            "2007-12-25T23:00:00"});
                table1.AddRow(new string[] {
                            "2008",
                            "2008-12-25T23:00:00"});
#line 21
await testRunner.ThenAsync("the UTC Statdate is as follow:", ((string)(null)), table1, "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("As from 2009 the Top2000 starts at first christmas day at noon (CET)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "All Editions")]
        public async System.Threading.Tasks.Task AsFrom2009TheTop2000StartsAtFirstChristmasDayAtNoonCET()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("As from 2009 the Top2000 starts at first christmas day at noon (CET)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 34
await testRunner.GivenAsync("All data scripts", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 35
await testRunner.WhenAsync("the feature is executed", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
                global::Reqnroll.Table table2 = new global::Reqnroll.Table(new string[] {
                            "Year",
                            "UTC Startdate"});
                table2.AddRow(new string[] {
                            "2009",
                            "2009-12-25T11:00:00"});
                table2.AddRow(new string[] {
                            "2010",
                            "2010-12-25T11:00:00"});
                table2.AddRow(new string[] {
                            "2011",
                            "2011-12-25T11:00:00"});
                table2.AddRow(new string[] {
                            "2012",
                            "2012-12-25T11:00:00"});
                table2.AddRow(new string[] {
                            "2013",
                            "2013-12-25T11:00:00"});
                table2.AddRow(new string[] {
                            "2014",
                            "2014-12-25T11:00:00"});
#line 36
await testRunner.ThenAsync("the UTC Statdate is as follow:", ((string)(null)), table2, "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("As from 2015 the Top2000 starts three hours earlier")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "All Editions")]
        public async System.Threading.Tasks.Task AsFrom2015TheTop2000StartsThreeHoursEarlier()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("As from 2015 the Top2000 starts three hours earlier", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 45
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 46
await testRunner.GivenAsync("All data scripts", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 47
await testRunner.WhenAsync("the feature is executed", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
                global::Reqnroll.Table table3 = new global::Reqnroll.Table(new string[] {
                            "Year",
                            "UTC Startdate"});
                table3.AddRow(new string[] {
                            "2015",
                            "2015-12-25T08:00:00"});
                table3.AddRow(new string[] {
                            "2016",
                            "2016-12-25T08:00:00"});
                table3.AddRow(new string[] {
                            "2017",
                            "2017-12-25T08:00:00"});
                table3.AddRow(new string[] {
                            "2018",
                            "2018-12-25T08:00:00"});
#line 48
await testRunner.ThenAsync("the UTC Statdate is as follow:", ((string)(null)), table3, "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("In 2019 the Top2000 start at 08:00")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "All Editions")]
        public async System.Threading.Tasks.Task In2019TheTop2000StartAt0800()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("In 2019 the Top2000 start at 08:00", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 55
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 56
await testRunner.GivenAsync("All data scripts", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 57
await testRunner.WhenAsync("the feature is executed", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
                global::Reqnroll.Table table4 = new global::Reqnroll.Table(new string[] {
                            "Year",
                            "UTC Startdate"});
                table4.AddRow(new string[] {
                            "2019",
                            "2019-12-25T07:00:00"});
#line 58
await testRunner.ThenAsync("the UTC Statdate is as follow:", ((string)(null)), table4, "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("As from 2020 the Top2000 starts at the start of boxing day (CET)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "All Editions")]
        public async System.Threading.Tasks.Task AsFrom2020TheTop2000StartsAtTheStartOfBoxingDayCET()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("As from 2020 the Top2000 starts at the start of boxing day (CET)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 62
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 63
await testRunner.GivenAsync("All data scripts", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 64
await testRunner.WhenAsync("the feature is executed", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
                global::Reqnroll.Table table5 = new global::Reqnroll.Table(new string[] {
                            "Year",
                            "UTC Startdate"});
                table5.AddRow(new string[] {
                            "2020",
                            "2020-12-24T23:00:00"});
                table5.AddRow(new string[] {
                            "2021",
                            "2021-12-24T23:00:00"});
                table5.AddRow(new string[] {
                            "2022",
                            "2022-12-24T23:00:00"});
                table5.AddRow(new string[] {
                            "2024",
                            "2024-12-24T23:00:00"});
#line 65
await testRunner.ThenAsync("the UTC Statdate is as follow:", ((string)(null)), table5, "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The List of 2023 started earlier than usual because it was the 25 edition")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "All Editions")]
        public async System.Threading.Tasks.Task TheListOf2023StartedEarlierThanUsualBecauseItWasThe25Edition()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("The List of 2023 started earlier than usual because it was the 25 edition", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 72
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 73
await testRunner.GivenAsync("All data scripts", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 74
await testRunner.WhenAsync("the feature is executed", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
                global::Reqnroll.Table table6 = new global::Reqnroll.Table(new string[] {
                            "Year",
                            "UTC Startdate"});
                table6.AddRow(new string[] {
                            "2023",
                            "2023-12-11T09:00:00"});
#line 75
await testRunner.ThenAsync("the UTC Statdate is as follow:", ((string)(null)), table6, "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
