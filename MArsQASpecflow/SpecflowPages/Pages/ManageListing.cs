using MArsQASpecflow.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MArsQASpecflow.SpecflowPages.Pages
{
    public class ManageListing
    {
        
        public ManageListing()
        {
        }


        #region  Initialize Web Elements 

           public IWebElement ManageListings => Driver.driver.FindElement(By.LinkText("Manage Listings"));

            public IWebElement ActiveServic => Driver.driver.FindElement(By.XPath("(//input[@name='isActive'])[1]"));

            public IWebElement View => Driver.driver.FindElement(By.XPath("(//i[@class='eye icon'])[1]"));

            public IWebElement Edit => Driver.driver.FindElement(By.XPath("(//i[@class='outline write icon'])[1]"));

            public IWebElement Delete => Driver.driver.FindElement(By.XPath("(//i[@class='remove icon'])[1]"));

            public IWebElement ClickOnYes => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));

            public IWebElement SuccessMsg => Driver.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div"));


        #endregion

        public void ManageList()
        {
            Thread.Sleep(2000);
            // Navigate to page Manage Listing
            ManageListings.Click();
        }

        public void ActiveService()
        { 
                ActiveServic.WaitForElementClickable(Driver.driver, 60);
                ActiveServic.Click();
                Thread.Sleep(3000);
            }

           
            public void EditServiceList()
            {
                Thread.Sleep(2000);
                // Navigate to page Manage Listing
                ManageListings.Click();
                // click on Edit button
                Edit.WaitForElementClickable(Driver.driver, 60);
                Edit.Click();
                // Update existing data                 
                ShareSkill edit = new ShareSkill();
                edit.EditSkill();
            }
        public void DeleteServiceList()
        {
            // Navigate to page Manage Listing
            //ManageListing.Click();
            Thread.Sleep(2000);
            // click on delete button             
            Delete.WaitForElementClickable(Driver.driver, 60);
            Delete.Click();
           }
        public void DeleteAlert()
           
            { 
                // Switch to Popup button
                ClickOnYes.WaitForElementClickable(Driver.driver, 60);
                ClickOnYes.Click();
                Thread.Sleep(1000);

            }
        public void DeleteVerification()
        {

            string ExpectedUpdateMsg = "Selenium has been deleted";
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            string ActualMsg = SuccessMsg.Text;

            Assert.AreEqual(ExpectedUpdateMsg, ActualMsg);
            Console.WriteLine(ExpectedUpdateMsg);
        }
            public void ViewServiceList()
            {
                Thread.Sleep(2000);
                // Navigate to page Manage Listing
                ManageListings.Click();
                // View Service Listing
                View.WaitForElementClickable(Driver.driver, 60);
                View.Click();
                Thread.Sleep(3000);
                // Validate view listing through Page title
                String actualTitle = Driver.driver.Title;
                Assert.AreEqual(actualTitle, "Service Detail");

            }
        }
    }
