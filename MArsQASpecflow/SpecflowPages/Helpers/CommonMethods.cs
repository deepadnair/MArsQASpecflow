

using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;



namespace MArsQASpecflow.SpecflowPages.Helpers
{
    class CommonMethods
    {
        public class SaveScreenShotClass
        {

            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".png");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Png);
                return fileName.ToString();
            }
        }

        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;
        private static ExtentHtmlReporter htmlReporter;

       /* public static void ExtentReports()
        {
           /* if (extent == null)
            {
                string reportPath = ConstantHelpers.ReportPath;
                string reportFile = DateTime.Now.ToString().Replace("/", "_").Replace(":", "_").Replace(".", "_");
                htmlReporter = new ExtentHtmlReporter(reportPath + reportFile);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddTestRunnerLogs(reportPath + "Extent Config.xml");
            }

             extent = new ExtentReports(ConstantHelpers.ReportPath, true, DisplayOrder.NewestFirst);
            extent.LoadConfig(ConstantHelpers.ReportXMLPath);
        }*/


       
    }





    #endregion



}

