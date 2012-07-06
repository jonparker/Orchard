﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("The compilation of modules installed in a site")]
    public partial class TheCompilationOfModulesInstalledInASiteFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SiteCompilation.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "The compilation of modules installed in a site", "  In order to install on Orchard site\r\n  As a privileged user\r\n  I want to have t" +
                    "he modules compiled/installed properly", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dynamic compilation can be disabled")]
        public virtual void DynamicCompilationCanBeDisabled()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dynamic compilation can be disabled", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
    testRunner.Given("I have chosen to load modules with dynamic compilation disabled");
#line 8
        testRunner.And("I have installed Orchard");
#line 9
    testRunner.When("I go to \"admin\"");
#line 10
    testRunner.Then("I should see \"<div id=\"orchard-version\">Orchard v(?:\\.\\d+){2,4}</div>\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dynamic compilation will kick in if modules are deployed as source files only")]
        public virtual void DynamicCompilationWillKickInIfModulesAreDeployedAsSourceFilesOnly()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dynamic compilation will kick in if modules are deployed as source files only", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
    testRunner.Given("I have chosen to deploy modules as source files only");
#line 14
        testRunner.And("I have installed Orchard");
#line 15
    testRunner.When("I go to \"admin\"");
#line 16
    testRunner.Then("I should see \"<div id=\"orchard-version\">Orchard v(?:\\.\\d+){2,4}</div>\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dynamic compilation can be forced by disabling the precompiled module loader")]
        public virtual void DynamicCompilationCanBeForcedByDisablingThePrecompiledModuleLoader()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dynamic compilation can be forced by disabling the precompiled module loader", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
    testRunner.Given("I have chosen to load modules using dymamic compilation only");
#line 20
        testRunner.And("I have installed Orchard");
#line 21
    testRunner.When("I go to \"admin\"");
#line 22
    testRunner.Then("I should see \"<div id=\"orchard-version\">Orchard v(?:\\.\\d+){2,4}</div>\"");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
