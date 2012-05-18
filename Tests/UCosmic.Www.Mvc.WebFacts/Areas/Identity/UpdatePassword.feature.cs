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
namespace UCosmic.Www.Mvc.Areas.Identity
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ChangeMyPasswordFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UpdatePassword.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Change My Password", "  In order to protect access to my sensitive information\r\n  As a UCosmic user\r\n  " +
                    "I want to change my password", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Change My Password")))
            {
                UCosmic.Www.Mvc.Areas.Identity.ChangeMyPasswordFeature.FeatureSetup(null);
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
        
        public virtual void ChangePasswordSuccessfullyAfterMakingTypingMistakes(string browser, string emailAddress, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UsingFreshExamplePasswords"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change Password successfully after making typing mistakes", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 9
    testRunner.Given(string.Format("I am using the {0} browser", browser));
#line 10
    testRunner.And(string.Format("I am signed in as {0}", emailAddress));
#line 11
    testRunner.And("I am starting from the Personal Home page");
#line 12
    testRunner.And("I see a \"Change Password\" link");
#line 14
    testRunner.When("I click the \"Change Password\" link");
#line 15
    testRunner.Then("I should see the Change Password page");
#line 16
    testRunner.And("I should see a \"Cancel\" link");
#line 19
    testRunner.When("I click the \"Cancel\" link");
#line 20
    testRunner.Then("I should see the Personal Home page");
#line 21
    testRunner.When("I click the \"Change Password\" link");
#line 22
    testRunner.Then("I should see the Change Password page");
#line 25
    testRunner.When("I type \"\" into the Current Password text field");
#line 26
    testRunner.And("I type \"\" into the New Password text field");
#line 27
    testRunner.And("I type \"\" into the New Password Confirmation text field");
#line 28
    testRunner.And("I click the \"Change Password\" submit button");
#line 29
    testRunner.Then("I should still see the Change Password page");
#line 30
    testRunner.And("I should see the Required error message for the Current Password text field");
#line 31
    testRunner.And("I should see the Required error message for the New Password text field");
#line 32
    testRunner.And("I should see the Required error message for the New Password Confirmation text fi" +
                    "eld");
#line 35
    testRunner.When("I type \"asdfasdf\" into the Current Password text field");
#line 36
    testRunner.And("I type \"pass\" into the New Password text field");
#line 37
    testRunner.And("I type \"pass\" into the New Password Confirmation text field");
#line 38
    testRunner.And("I click the \"Change Password\" submit button");
#line 39
    testRunner.Then("I should still see the Change Password page");
#line 40
    testRunner.And("I should see the Too Short error message for the New Password text field");
#line 41
    testRunner.But("I should not see any error messages for the Current Password text field");
#line 42
    testRunner.And("I should not see any error messages for the New Password Confirmation text field");
#line 45
    testRunner.When("I type \"asdfasdf\" into the Current Password text field");
#line 46
    testRunner.And("I type \"password\" into the New Password text field");
#line 47
    testRunner.And("I type \"passwrod\" into the New Password Confirmation text field");
#line 48
    testRunner.And("I click the \"Change Password\" submit button");
#line 49
    testRunner.Then("I should still see the Change Password page");
#line 50
    testRunner.And("I should see the No Match error message for the New Password Confirmation text fi" +
                    "eld");
#line 51
    testRunner.But("I should not see any error messages for the Current Password text field");
#line 52
    testRunner.And("I should not see any error messages for the New Password text field");
#line 55
    testRunner.When("I type \"asdfasdf\" into the Current Password text field");
#line 56
    testRunner.And("I type \"password\" into the New Password text field");
#line 57
    testRunner.And("I type \"\" into the New Password Confirmation text field");
#line 58
    testRunner.And("I click the \"Change Password\" submit button");
#line 59
    testRunner.Then("I should still see the Change Password page");
#line 60
    testRunner.And("I should see the Required error message for the New Password Confirmation text fi" +
                    "eld");
#line 61
    testRunner.But("I should not see any error messages for the Current Password text field");
#line 62
    testRunner.And("I should not see any error messages for the New Password text field");
#line 65
    testRunner.When("I type \"incorrect\" into the Current Password text field");
#line 66
    testRunner.And("I type \"password\" into the New Password text field");
#line 67
    testRunner.And("I type \"password\" into the New Password Confirmation text field");
#line 68
    testRunner.And("I click the \"Change Password\" submit button");
#line 69
    testRunner.Then("I should still see the Change Password page");
#line 70
    testRunner.And("I should see the Invalid error message for the Current Password text field");
#line 71
    testRunner.But("I should not see any error messages for the New Password text field");
#line 72
    testRunner.And("I should not see any error messages for the New Password Confirmation text field");
#line 75
    testRunner.When("I type \"asdfasdf\" into the Current Password text field");
#line 76
    testRunner.And("I type \"newpwd\" into the New Password text field");
#line 77
    testRunner.And("I type \"newpwd\" into the New Password Confirmation text field");
#line 78
    testRunner.And("I click the \"Change Password\" submit button");
#line 79
    testRunner.Then("I should see the Personal Home page");
#line 80
    testRunner.And("I should see the flash feedback message \"Your password has been changed. Use your" +
                    " new password to sign on next time.\"");
#line 81
    testRunner.And("I should see a \"Sign Out\" link");
#line 84
    testRunner.When("I click the \"Sign Out\" link");
#line 85
    testRunner.Then("I should see the Sign Out page");
#line 86
    testRunner.And("I should see a \"Sign On\" link");
#line 88
    testRunner.When("I click the \"Sign On\" link");
#line 89
    testRunner.Then("I should see the Sign On page");
#line 91
    testRunner.When(string.Format("I type \"{0}\" into the Email Address text field", emailAddress));
#line 92
    testRunner.And("I click the \"Next >>\" submit button");
#line 93
    testRunner.Then("I should see the Enter Password page");
#line 95
    testRunner.When("I type \"newpwd\" into the Password text field");
#line 96
    testRunner.And("I click the \"Sign On\" submit button");
#line 97
    testRunner.Then("I should see the Personal Home page");
#line 98
    testRunner.And("I should see a \"Sign Out\" link");
#line 99
    testRunner.And("I should see a \"Change Password\" link");
#line 101
    testRunner.When("I click the \"Change Password\" link");
#line 102
    testRunner.Then("I should see the Change Password page");
#line 105
    testRunner.When("I type \"newpwd\" into the Current Password text field");
#line 106
    testRunner.And("I type \"asdfasdf\" into the New Password text field");
#line 107
    testRunner.And("I type \"asdfasdf\" into the New Password Confirmation text field");
#line 108
    testRunner.And("I click the \"Change Password\" submit button");
#line 109
    testRunner.Then("I should see the Personal Home page");
#line 110
    testRunner.And("I should see the flash feedback message \"Your password has been changed. Use your" +
                    " new password to sign on next time.\"");
#line 111
    testRunner.And("I should see a \"Sign Out\" link");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Change Password successfully after making typing mistakes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Change My Password")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExamplePasswords")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Browser", "Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailAddress", "any1@usil.edu.pe")]
        public virtual void ChangePasswordSuccessfullyAfterMakingTypingMistakes_Chrome()
        {
            this.ChangePasswordSuccessfullyAfterMakingTypingMistakes("Chrome", "any1@usil.edu.pe", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Change Password successfully after making typing mistakes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Change My Password")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExamplePasswords")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Browser", "Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailAddress", "any1@bjtu.edu.cn")]
        public virtual void ChangePasswordSuccessfullyAfterMakingTypingMistakes_Firefox()
        {
            this.ChangePasswordSuccessfullyAfterMakingTypingMistakes("Firefox", "any1@bjtu.edu.cn", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Change Password successfully after making typing mistakes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Change My Password")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExamplePasswords")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MSIE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Browser", "MSIE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailAddress", "any1@napier.ac.uk")]
        public virtual void ChangePasswordSuccessfullyAfterMakingTypingMistakes_MSIE()
        {
            this.ChangePasswordSuccessfullyAfterMakingTypingMistakes("MSIE", "any1@napier.ac.uk", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion