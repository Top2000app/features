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
    public partial class TrackInformationFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "TrackInformation", null, global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "TrackInformation.feature"
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
        
        public virtual async System.Threading.Tasks.Task FeatureBackgroundAsync()
        {
#line 3
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Track information contains the static data from a track")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TrackInformation")]
        public async System.Threading.Tasks.Task TrackInformationContainsTheStaticDataFromATrack()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Track information contains the static data from a track", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 6
await testRunner.GivenAsync("the client database is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 7
await testRunner.WhenAsync("the track information feature is executed for TrackId 1780", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 8
await testRunner.ThenAsync("the title is \"L\'Été Indien\" from \'Joe Dassin\' which is recorded in the year 1975", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Tracks that are recorded after the first edition are listed as Not available")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TrackInformation")]
        public async System.Threading.Tasks.Task TracksThatAreRecordedAfterTheFirstEditionAreListedAsNotAvailable()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Tracks that are recorded after the first edition are listed as Not available", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 10
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 11
await testRunner.GivenAsync("the client database is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 12
await testRunner.WhenAsync("the track information feature is executed for TrackId 1267", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 13
await testRunner.ThenAsync("the title is \"Hurt\" from \'Johnny Cash\' which is recorded in the year 2003", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
                global::Reqnroll.Table table12 = new global::Reqnroll.Table(new string[] {
                            "Edition"});
                table12.AddRow(new string[] {
                            "2002"});
                table12.AddRow(new string[] {
                            "2001"});
                table12.AddRow(new string[] {
                            "2000"});
                table12.AddRow(new string[] {
                            "1999"});
#line 14
await testRunner.AndAsync("the following years are listed as \'NotAvailable\'", ((string)(null)), table12, "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Track that were recorded but did not made it on the list are listed as NotListed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TrackInformation")]
        public async System.Threading.Tasks.Task TrackThatWereRecordedButDidNotMadeItOnTheListAreListedAsNotListed()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Track that were recorded but did not made it on the list are listed as NotListed", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 21
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 22
await testRunner.GivenAsync("the client database is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 23
await testRunner.WhenAsync("the track information feature is executed for TrackId 1267", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 24
await testRunner.ThenAsync("the title is \"Hurt\" from \'Johnny Cash\' which is recorded in the year 2003", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
                global::Reqnroll.Table table13 = new global::Reqnroll.Table(new string[] {
                            "Edition"});
                table13.AddRow(new string[] {
                            "2003"});
                table13.AddRow(new string[] {
                            "2004"});
                table13.AddRow(new string[] {
                            "2005"});
                table13.AddRow(new string[] {
                            "2006"});
                table13.AddRow(new string[] {
                            "2007"});
                table13.AddRow(new string[] {
                            "2008"});
#line 25
await testRunner.AndAsync("the following years are listed as \'NotListed\'", ((string)(null)), table13, "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The first time a track is listed the status of the listing is New")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TrackInformation")]
        public async System.Threading.Tasks.Task TheFirstTimeATrackIsListedTheStatusOfTheListingIsNew()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("The first time a track is listed the status of the listing is New", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 34
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 35
await testRunner.GivenAsync("the client database is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 36
await testRunner.WhenAsync("the track information feature is executed for TrackId 1267", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 37
await testRunner.ThenAsync("the title is \"Hurt\" from \'Johnny Cash\' which is recorded in the year 2003", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 38
await testRunner.AndAsync("the listing 2009 is listed as \'New\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute(("Tracks that are listed again but was not in the previous edition the status is li" +
            "sted as Back"))]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TrackInformation")]
        public async System.Threading.Tasks.Task TracksThatAreListedAgainButWasNotInThePreviousEditionTheStatusIsListedAsBack()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo(("Tracks that are listed again but was not in the previous edition the status is li" +
                    "sted as Back"), null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 40
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 41
await testRunner.GivenAsync("the client database is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 42
await testRunner.WhenAsync("the track information feature is executed for TrackId 2560", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 43
await testRunner.ThenAsync("the title is \"Sad But True\" from \'Metallica\' which is recorded in the year 1993", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 44
await testRunner.AndAsync("the listing 2011 is listed as \'Back\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute(("Tracks that are higher on the list than previous edition are listed are Increased" +
            " and a offset is indicating the delta"))]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TrackInformation")]
        public async System.Threading.Tasks.Task TracksThatAreHigherOnTheListThanPreviousEditionAreListedAreIncreasedAndAOffsetIsIndicatingTheDelta()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo(("Tracks that are higher on the list than previous edition are listed are Increased" +
                    " and a offset is indicating the delta"), null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 47
await testRunner.GivenAsync("the client database is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 48
await testRunner.WhenAsync("the track information feature is executed for TrackId 1664", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 49
await testRunner.ThenAsync("the title is \"Killer Queen\" from \'Queen\' which is recorded in the year 1974", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
                global::Reqnroll.Table table14 = new global::Reqnroll.Table(new string[] {
                            "Edition",
                            "Offset"});
                table14.AddRow(new string[] {
                            "2000",
                            "33"});
                table14.AddRow(new string[] {
                            "2002",
                            "19"});
                table14.AddRow(new string[] {
                            "2008",
                            "262"});
                table14.AddRow(new string[] {
                            "2011",
                            "85"});
                table14.AddRow(new string[] {
                            "2017",
                            "9"});
                table14.AddRow(new string[] {
                            "2018",
                            "222"});
#line 50
await testRunner.AndAsync("the following years are listed as \'Increased\'", ((string)(null)), table14, "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute(("Tracks that are lower on the list than previous edition are listed are Decreased " +
            "and a offset is indicating the delta"))]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TrackInformation")]
        public async System.Threading.Tasks.Task TracksThatAreLowerOnTheListThanPreviousEditionAreListedAreDecreasedAndAOffsetIsIndicatingTheDelta()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo(("Tracks that are lower on the list than previous edition are listed are Decreased " +
                    "and a offset is indicating the delta"), null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 59
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 60
await testRunner.GivenAsync("the client database is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 61
await testRunner.WhenAsync("the track information feature is executed for TrackId 1664", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 62
await testRunner.ThenAsync("the title is \"Killer Queen\" from \'Queen\' which is recorded in the year 1974", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
                global::Reqnroll.Table table15 = new global::Reqnroll.Table(new string[] {
                            "Edition",
                            "Offset"});
                table15.AddRow(new string[] {
                            "2001",
                            "27"});
                table15.AddRow(new string[] {
                            "2003",
                            "1"});
                table15.AddRow(new string[] {
                            "2004",
                            "30"});
                table15.AddRow(new string[] {
                            "2005",
                            "45"});
                table15.AddRow(new string[] {
                            "2006",
                            "27"});
                table15.AddRow(new string[] {
                            "2007",
                            "255"});
                table15.AddRow(new string[] {
                            "2009",
                            "7"});
                table15.AddRow(new string[] {
                            "2010",
                            "76"});
                table15.AddRow(new string[] {
                            "2012",
                            "13"});
                table15.AddRow(new string[] {
                            "2013",
                            "27"});
                table15.AddRow(new string[] {
                            "2014",
                            "18"});
                table15.AddRow(new string[] {
                            "2015",
                            "10"});
                table15.AddRow(new string[] {
                            "2016",
                            "3"});
                table15.AddRow(new string[] {
                            "2019",
                            "18"});
                table15.AddRow(new string[] {
                            "2020",
                            "25"});
                table15.AddRow(new string[] {
                            "2020",
                            "38"});
#line 63
await testRunner.AndAsync("the following years are listed as \'Decreased\'", ((string)(null)), table15, "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute(("Tracks that haven\'t change position since the previous edition are listed as Unch" +
            "anged"))]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TrackInformation")]
        public async System.Threading.Tasks.Task TracksThatHaventChangePositionSinceThePreviousEditionAreListedAsUnchanged()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo(("Tracks that haven\'t change position since the previous edition are listed as Unch" +
                    "anged"), null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 82
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 83
await testRunner.GivenAsync("the client database is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 84
await testRunner.WhenAsync("the track information feature is executed for TrackId 2218", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 85
await testRunner.ThenAsync(("the title is \"Nothing Else Matters\" from \'Metallica\' which is recorded in the yea" +
                        "r 1992"), ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
                global::Reqnroll.Table table16 = new global::Reqnroll.Table(new string[] {
                            "Edition",
                            "Offset"});
                table16.AddRow(new string[] {
                            "2017",
                            "0"});
                table16.AddRow(new string[] {
                            "2012",
                            "0"});
#line 86
await testRunner.AndAsync("the following years are listed as \'Unchanged\'", ((string)(null)), table16, "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute(("\'Since release\' is the statistic that shows how many times the tracks could have " +
            "been listed"))]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TrackInformation")]
        public async System.Threading.Tasks.Task SinceReleaseIsTheStatisticThatShowsHowManyTimesTheTracksCouldHaveBeenListed()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo(("\'Since release\' is the statistic that shows how many times the tracks could have " +
                    "been listed"), null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 91
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 92
await testRunner.GivenAsync("the client database is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 93
await testRunner.WhenAsync("the track information feature is executed for TrackId 3966", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 94
await testRunner.ThenAsync("the title is \"Hello\" from \'Adele\' which is recorded in the year 2015", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 95
await testRunner.AndAsync("it could have been on the Top2000 for 10 times", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 96
await testRunner.AndAsync("is it listed for 10 times", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Record high shows the highest listing for the track")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TrackInformation")]
        public async System.Threading.Tasks.Task RecordHighShowsTheHighestListingForTheTrack()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Record high shows the highest listing for the track", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 98
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 99
await testRunner.GivenAsync("the client database is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 100
await testRunner.WhenAsync("the track information feature is executed for TrackId 1496", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 101
await testRunner.ThenAsync("the title is \"Imagine\" from \'John Lennon\' which is recorded in the year 1971", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 102
await testRunner.AndAsync("the record high is number 1 on 2015", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Record low shows the lowest listing for the track")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TrackInformation")]
        public async System.Threading.Tasks.Task RecordLowShowsTheLowestListingForTheTrack()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Record low shows the lowest listing for the track", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 104
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 105
await testRunner.GivenAsync("the client database is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 106
await testRunner.WhenAsync("the track information feature is executed for TrackId 1496", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 107
await testRunner.ThenAsync("the title is \"Imagine\" from \'John Lennon\' which is recorded in the year 1971", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 108
await testRunner.AndAsync("the record low is number 52 in 2022", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Last postion shows the position of latest edition where the track was listed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TrackInformation")]
        public async System.Threading.Tasks.Task LastPostionShowsThePositionOfLatestEditionWhereTheTrackWasListed()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Last postion shows the position of latest edition where the track was listed", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 110
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 111
await testRunner.GivenAsync("the client database is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 112
await testRunner.WhenAsync("the track information feature is executed for TrackId 1496", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 113
await testRunner.ThenAsync("the title is \"Imagine\" from \'John Lennon\' which is recorded in the year 1971", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 114
await testRunner.AndAsync("the Lastest position is number 46 in 2024", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("First position shows the position of the first edition where the track was listed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TrackInformation")]
        public async System.Threading.Tasks.Task FirstPositionShowsThePositionOfTheFirstEditionWhereTheTrackWasListed()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("First position shows the position of the first edition where the track was listed", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 116
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 117
await testRunner.GivenAsync("the client database is created", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 118
await testRunner.WhenAsync("the track information feature is executed for TrackId 1496", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 119
await testRunner.ThenAsync("the title is \"Imagine\" from \'John Lennon\' which is recorded in the year 1971", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 120
await testRunner.AndAsync("the first position is number 7 in 1999", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
