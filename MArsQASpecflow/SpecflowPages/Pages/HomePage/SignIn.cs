using MArsQASpecflow.SpecflowPages.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MArsQASpecflow.SpecflowPages.Pages
{
    class SignIn
    {
        private static IWebElement SignInBtn => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Sign In']"));
        private static IWebElement Email => Driver.driver.FindElement(By.Name("email"));
        private static IWebElement Password => Driver.driver.FindElement(By.Name("password"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
        public static void SigninStep()
        {
            // Driver.NavigateUrl();
            
            SignInBtn.Click();
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SignIn");
            Thread.Sleep(3000);
            Email.SendKeys(ExceLibHelper.ReadData(2, "Username"));
            Password.SendKeys(ExceLibHelper.ReadData(2, "Password"));
            LoginBtn.Click();
        }
   /*     public static void Login()
        {
            Driver.NavigateUrl();

            //Enter Url
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            //Enter Username
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("");

            //Enter password
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("");

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

        }*/

    }
}
