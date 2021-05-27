using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MArsQASpecflow.SpecflowPages.Helpers
{
   public class Driver
    {
        public static IWebDriver driver { get; set; }

        public static void Initialize()
        {
            try
            {
                //Defining the browser
                driver = new ChromeDriver();
                TurnOnWait();

                //Maximise the window
                driver.Manage().Window.Maximize();
                //Navigate to home page
                driver.Navigate().GoToUrl(BaseUrl);

            }
            catch (TimeoutException e)
            {
                Thread.Sleep(5000);
                Console.WriteLine("Error");
            }
        }

        public static string BaseUrl = "http://localhost:5000/Home";
        //  {
        //      get { return ConstantHelpers.Url; }
        //   }


        //Implicit Wait
        public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        //Close the browser
        public void Close()
        {
            driver.Quit();
        }


    }
}
