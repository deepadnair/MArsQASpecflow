using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

using MArsQASpecflow.SpecflowPages.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MArsQASpecflow.SpecflowPages.Helpers.CommonMethods;

namespace MArsQASpecflow.SpecflowPages.Utils
{
    [Binding]
    public  class Hooks1:Driver
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        public static string ReportPath;
        private static ExtentHtmlReporter htmlReporter;

        [BeforeScenario]
        [Obsolete]
        public void Setup()
        {
            //launch the browser

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Initialize();
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SignIn");
            //call the SignIn class
            MArsQASpecflow.SpecflowPages.Pages.SignIn.SigninStep();

            Console.WriteLine("BeforeScenario");
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }


       
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            

            string reportPath = ConstantHelpers.ReportPath;
             htmlReporter = new ExtentHtmlReporter(reportPath);
             extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddTestRunnerLogs(reportPath + "Extent Config.xml");
        }

        [BeforeFeature]
        [Obsolete]
        public static void BeforeFeature()
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            Console.WriteLine("BeforeFeature");
        }
       
       
        [AfterStep]
        [Obsolete]
        public void InsertReportingSteps()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if(stepType == "When")
                                scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if(stepType == "Then")
                                scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if(stepType == "And")
                                scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if(ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if(stepType == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if(stepType == "Then") {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if(stepType == "And")
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
            }
        }
       
        [AfterTestRun]
        public static void AfterTestRun()
        {
           
            //kill the browser
            //Flush report once test completes
            extent.Flush();
            //kill the browser
        }









        [AfterScenario]
        public void TearDown()
        {

            Thread.Sleep(5000);
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            //   test.Log(Status.Info, "Snapshot below: " + test.AddScreenCaptureFromPath());

            // end test. (Reports)
        //    CommonMethods.extent.RemoveTest(CommonMethods.test);

            // calling Flush writes everything to the log file (Reports)
       //     CommonMethods.extent.Flush();

            //Close the browser
            driver.Quit();
        }




    }
}
