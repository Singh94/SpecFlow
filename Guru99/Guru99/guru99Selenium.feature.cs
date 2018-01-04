﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Guru99
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("guru99Selenium", Description="\tIn order to check login feature\r\n\tAs a user\r\n\tI want to check if login to bank i" +
        "s successful", SourceFile="guru99Selenium.feature", SourceLine=0)]
    public partial class Guru99SeleniumFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "guru99Selenium.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "guru99Selenium", "\tIn order to check login feature\r\n\tAs a user\r\n\tI want to check if login to bank i" +
                    "s successful", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Login to Guru99 Bank", new string[] {
                "mytag"}, SourceLine=6)]
        public virtual void LoginToGuru99Bank()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login to Guru99 Bank", new string[] {
                        "mytag"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I open firefox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("I go to \"http://www.demo.guru99.com/V4/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I enter username of \"mngr111938\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And("I enter password of \"abyvUqe\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("I click login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.Then("I should be logged-in with success message \"Welcome To Manager\'s Page of Guru99 B" +
                    "ank\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.And("I close the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
