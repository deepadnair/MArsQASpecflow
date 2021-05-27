using MArsQASpecflow.SpecflowPages.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MArsQASpecflow.SpecflowPages.Pages.HomePage
{
    class SignUp
    {


        #region  Initialize Web Elements 
        //Finding the Join 

        private static IWebElement Join = Driver.driver.FindElement(By.XPath("//*[@id='home']//button[text()='Join']"));

     //   private static IWebElement JoinButton => Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/button"));
        private static IWebElement Firstname => Driver.driver.FindElement(By.XPath("//input[@name='firstName']"));
        private static IWebElement Lastname => Driver.driver.FindElement(By.XPath("//input[@name='lastName']"));
        private static IWebElement EmailId => Driver.driver.FindElement(By.XPath("//input[@name='email']"));
        private static IWebElement EPassword => Driver.driver.FindElement(By.XPath("//input[@name='password']"));
        private static IWebElement ConfirmPassword => Driver.driver.FindElement(By.XPath("//input[@name='confirmPassword']"));
        private static IWebElement Checkbox => Driver.driver.FindElement(By.XPath("//input[@name='terms']"));
        private static IWebElement JoinBtn => Driver.driver.FindElement(By.XPath("//div[@id='submit-btn']"));
        private static IWebElement FirstNameAlert => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/div"));
        private static IWebElement LastNameAlert => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/div"));
        private static IWebElement EmailAlert => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/div"));
        private static IWebElement PasswordAlert => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div"));
        private static IWebElement ConfirmPswdAlert => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/div"));
        private static IWebElement TermsAlert => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[7]/div"));
        private static IWebElement Background => Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[4]/div/input"));





        internal void JoinLnk() =>Join.Click();
        #endregion
        internal void RegistName(string FirstName, string LastName)
        {
            //Populate the excel data
            //  ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SignUp");
            // Navigate to Url
            //  Driver.driver.Navigate().GoToUrl(ExceLibHelper.ReadData(2, "Url"));
            //Click on Join button

            Thread.Sleep(2000);

            //Enter FirstName
            Firstname.SendKeys(FirstName);

            //Enter LastName
            Lastname.SendKeys(LastName);
        }
        internal void RegistMail(string Email, string	Password,string ConfirmPswd)
        { 
              EmailId.SendKeys(Email);

            //Enter Password
            EPassword.SendKeys(Password);

            //Enter Password again to confirm
            ConfirmPassword.SendKeys(ConfirmPswd);
        }
    //Enter Email

    //Click on Checkbox
    internal void TermsCkBx() =>Checkbox.Click();

        //Click on join button to Sign Up
        internal void JnButtn() => JoinBtn.Click();
        
    }
}
