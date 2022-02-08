﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Treinamento.Versatile.UIAutomatedTesting.Configurations.Factories;

namespace Treinamento.Versatile.UIAutomatedTesting.Configurations.Helpers
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private static DriverFactory _driverFactory;
        private static ExtentTest _feature;
        private static ExtentTest _scenario;
        private static AventStack.ExtentReports.ExtentReports _extent;
        private static readonly string PathReport = SystemProperties.PathProject + "\\TestResults\\Report\\ExtentReport.html";

        public Hooks(IObjectContainer objectContainer) => _objectContainer = objectContainer;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Directory.CreateDirectory(SystemProperties.PathProject + Path.Combine("\\TestResults\\Report"));
            Directory.CreateDirectory(SystemProperties.PathProject + Path.Combine("\\TestResults\\Img"));
            _driverFactory = new DriverFactory();
            var reporter = new ExtentHtmlReporter(PathReport);
            _extent = new AventStack.ExtentReports.ExtentReports();
            _extent.AttachReporter(reporter);
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext) =>
                    _feature = _extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            _driverFactory._driver = _driverFactory.CreateDriver(Browsers.CHROME);
            _driverFactory._driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driverFactory.Maximize();
            _objectContainer.RegisterInstanceAs(_driverFactory.Driver());
            _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
            _scenario.AssignCategory(scenarioContext.ScenarioInfo.Tags);
        }

        [AfterStep]
        public static void InsertReportingSteps(ScenarioContext scenarioContext)
        {
            var ScreenShotFilePath = Path.Combine(SystemProperties.PathProject + "\\TestResults\\Img", Path.GetFileNameWithoutExtension(Path.GetTempFileName()) + ".png");
            var mediaModel = MediaEntityBuilder.CreateScreenCaptureFromPath(ScreenShotFilePath).Build();

            if (scenarioContext.TestError != null)
            {
                _driverFactory._driver.TakeScreenshot().SaveAsFile(ScreenShotFilePath, ScreenshotImageFormat.Png);
                switch (ScenarioStepContext.Current.StepInfo.StepDefinitionType)
                {
                    case TechTalk.SpecFlow.Bindings.StepDefinitionType.Given:
                        _scenario.CreateNode<Given>("Given " + ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message, mediaModel);
                        break;

                    case TechTalk.SpecFlow.Bindings.StepDefinitionType.When:
                        _scenario.CreateNode<When>("When " + ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message, mediaModel);
                        break;

                    case TechTalk.SpecFlow.Bindings.StepDefinitionType.Then:
                        _scenario.CreateNode<Then>("Then " + ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message, mediaModel);
                        break;
                }
            }

            if (scenarioContext.ScenarioExecutionStatus == ScenarioExecutionStatus.StepDefinitionPending)
            {
                switch (ScenarioStepContext.Current.StepInfo.StepDefinitionType)
                {
                    case TechTalk.SpecFlow.Bindings.StepDefinitionType.Given:
                        _scenario.CreateNode<Given>("Given " + ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending", mediaModel);
                        break;

                    case TechTalk.SpecFlow.Bindings.StepDefinitionType.When:
                        _scenario.CreateNode<When>("When " + ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending", mediaModel);
                        break;

                    case TechTalk.SpecFlow.Bindings.StepDefinitionType.Then:
                        _scenario.CreateNode<Then>("Then " + ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending", mediaModel);
                        break;
                }
            }

            if (scenarioContext.TestError == null)
            {
                _driverFactory._driver.TakeScreenshot().SaveAsFile(ScreenShotFilePath, ScreenshotImageFormat.Png);
                switch (ScenarioStepContext.Current.StepInfo.StepDefinitionType)
                {
                    case TechTalk.SpecFlow.Bindings.StepDefinitionType.Given:
                        _scenario.CreateNode<Given>("Given " + ScenarioStepContext.Current.StepInfo.Text).Pass(string.Empty, mediaModel);
                        break;

                    case TechTalk.SpecFlow.Bindings.StepDefinitionType.When:
                        _scenario.CreateNode<When>("When " + ScenarioStepContext.Current.StepInfo.Text).Pass(string.Empty, mediaModel);
                        break;

                    case TechTalk.SpecFlow.Bindings.StepDefinitionType.Then:
                        _scenario.CreateNode<Then>("Then " + ScenarioStepContext.Current.StepInfo.Text).Pass(string.Empty, mediaModel);
                        break;

                }
            }
        }
        [AfterScenario]
        public void AfterScenario()
        {
            _extent.Flush();
            _driverFactory.Quit();
            _driverFactory.Driver().Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
