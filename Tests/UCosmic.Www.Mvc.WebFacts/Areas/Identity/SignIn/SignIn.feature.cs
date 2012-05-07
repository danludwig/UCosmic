﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.17379
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UCosmic.Www.Mvc.Areas.Identity.SignIn
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SignInFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SignIn.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Sign In", "  In order to access my protected information\r\n  As a UCosmic user\r\n  I want to s" +
                    "ign in using my password", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Sign In")))
            {
                UCosmic.Www.Mvc.Areas.Identity.SignIn.SignInFeature.FeatureSetup(null);
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
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
    testRunner.Given("I am starting from the Home page");
#line 8
    testRunner.When("I am not signed on");
#line 9
    testRunner.Then("I should see a \"Sign On\" link");
#line 11
    testRunner.When("I click the \"Sign On\" link");
#line 12
    testRunner.Then("I should see the Sign On page");
#line 14
    testRunner.When("I type \"any1@suny.edu\" into the Email address field");
#line 15
    testRunner.And("I click the \"Next >>\" submit button");
#line 16
    testRunner.Then("I should see the Enter Password page");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sign In fails when password is empty")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sign In")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ClearSigningEmailAddress")]
        public virtual void SignInFailsWhenPasswordIsEmpty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sign In fails when password is empty", new string[] {
                        "ClearSigningEmailAddress"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 20
    testRunner.When("I click the \"Sign On\" submit button");
#line 21
    testRunner.Then("I should see the Required error message for the Password field");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sign In fails when password is incorrect")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sign In")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ClearSigningEmailAddress")]
        public virtual void SignInFailsWhenPasswordIsIncorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sign In fails when password is incorrect", new string[] {
                        "ClearSigningEmailAddress"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 25
    testRunner.When("I type \"incorrect\" into the Password field");
#line 26
    testRunner.And("I click the \"Sign On\" submit button");
#line 27
    testRunner.Then("I should see the \'Invalid with 4 remaining attempts\' error message for the Passwo" +
                    "rd field");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sign In succeeds when password is correct")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sign In")]
        public virtual void SignInSucceedsWhenPasswordIsCorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sign In succeeds when password is correct", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 30
    testRunner.When("I type \"asdfasdf\" into the Password field");
#line 31
    testRunner.And("I click the \"Sign On\" submit button");
#line 32
    testRunner.Then("I should see the Personal Home page");
#line 33
    testRunner.And("I should see a \"Sign Out\" link");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
