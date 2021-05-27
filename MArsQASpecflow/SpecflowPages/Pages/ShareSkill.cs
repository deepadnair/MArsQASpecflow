using AventStack.ExtentReports;
using MArsQASpecflow.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static MArsQASpecflow.SpecflowPages.Helpers.CommonMethods;

namespace MArsQASpecflow.SpecflowPages.Pages
{
    class ShareSkill
    {
        public enum BrowserType
        {
            Firefox,
            Chrome,

        }

       
       

        public ShareSkill()
        {
        }

        #region  Initialize Web Elements 
        // click on Share skill
        public IWebElement ShareSkills => Driver.driver.FindElement(By.LinkText("Share Skill"));
        //Fill value in title textbox
        public IWebElement Title => Driver.driver.FindElement(By.Name("title"));
        // Fill Value in Description textbox
        public IWebElement Description => Driver.driver.FindElement(By.Name("description"));
        // Click on Categories dropdown
        public IWebElement Category => Driver.driver.FindElement(By.Name("categoryId"));
        //Click on Categories dropdown
        public IWebElement SubCategory => Driver.driver.FindElement(By.Name("subcategoryId"));
        // Enter Tag Name in textbox
        public IWebElement Tags => Driver.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));
        // Select Service Type
        // Service type option 1
         public IWebElement ServiceTypeHourly => Driver.driver.FindElement(By.XPath("//input[@name='serviceType' and @value='0']"));
        // Service type option 2
         public IWebElement ServiceTypeOnOff => Driver.driver.FindElement(By.XPath("//input[@name='serviceType' and @value='1']"));
        // Select Location type
         public IWebElement LocationTypeOnsite => Driver.driver.FindElement(By.XPath("//input[@name='locationType' and @value='0']"));
        // Select option 2
        public IWebElement LocationTypeOnline => Driver.driver.FindElement(By.XPath("//input[@name='locationType' and @value='1']"));
        //Click on Start Date dropdown
        public IWebElement StartDate => Driver.driver.FindElement(By.Name("startDate"));

        //Click on End Date dropdown
         public IWebElement EndDate => Driver.driver.FindElement(By.Name("endDate"));

        //Storing the table of available days
        public IWebElement Days => Driver.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]"));
        // Storing value in start Time
        public IWebElement StartTime => Driver.driver.FindElement(By.XPath("//input[@name='StartTime' and @Index='1']"));
        // Storing value in start Time
        public IWebElement EndTime => Driver.driver.FindElement(By.XPath("//div/div[3]/input"));
        //Select Skill Trade 
        public IWebElement SkillExchange => Driver.driver.FindElement(By.XPath("//input[@name='skillTrades' and @value='true']"));
        // Select Credit
        public IWebElement Credit => Driver.driver.FindElement(By.XPath("//input[@name='skillTrades' and @value='false']"));
        // Enter amount for Credit
        public IWebElement CreditAmount => Driver.driver.FindElement(By.Name("charge"));
        // Enter Skill-Exchange
        public IWebElement RequiredSkills => Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper']//input[@placeholder='Add new tag']"));
        //Click on Active option
        public IWebElement StatusActive => Driver.driver.FindElement(By.XPath("//input[@name='isActive' and @value='true']"));
        //Click on Hidden option
        public IWebElement StatusHidden => Driver.driver.FindElement(By.XPath("//input[@name='isActive' and @value='false']"));
        // Add Work Samples
         public IWebElement WorkSample => Driver.driver.FindElement(By.XPath("//i[@class='huge plus circle icon padding-25']"));
        //Click on Save button
         public IWebElement Save => Driver.driver.FindElement(By.XPath("//input[@value='Save' and @type='button']"));
        // Click on Cancel
         public IWebElement Cancel => Driver.driver.FindElement(By.XPath("//input[@value='Cancel' and @type='button']"));
        #endregion

        #region Add new Skill
        public void NavSharSkill()
        {
            #region Navigate to Share Skills Page
            // Click on Share Skills Page
            ShareSkills.WaitForElementClickable(Helpers.Driver.driver, 60);
            ShareSkills.Click();
        }
        public void AddNewSkill()
        {
            //Populate the excel data            
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ShareSkills");
            #endregion

            #region Enter Title 
            Title.WaitForElementClickable(Helpers.Driver.driver, 60);
            //Enter the data in Title textbox
            Title.SendKeys(ExceLibHelper.ReadData(2, "title"));
            #endregion

            #region Enter Description
            //Enter the data in Description textbox
            Description.SendKeys(ExceLibHelper.ReadData(2, "EnterDescription"));
            #endregion

            #region Category Drop Down

            // Click on Category Dropdown
            Category.Click();
            // Select Category from Category Drop Down
            var SelectElement = new SelectElement(Category);
            SelectElement.SelectByText((ExceLibHelper.ReadData(2, "category")));
            // Click on Sub-Category Dropdown
            SubCategory.Click();
            //Select Sub-Category from the Drop Down
            var SelectElement1 = new SelectElement(SubCategory);
            SelectElement1.SelectByText((ExceLibHelper.ReadData(2, "subcategory")));
            #endregion

            #region Tags
            // Eneter Tag
            Tags.SendKeys(ExceLibHelper.ReadData(2, "TagName"));
            Tags.SendKeys(Keys.Enter);
            Tags.SendKeys(ExceLibHelper.ReadData(3, "TagName"));
            Tags.SendKeys(Keys.Enter);
            #endregion

            #region Service Type Selection
            // Service Type Selection
            if (ExceLibHelper.ReadData(2, "ServiceType") == "Hourly basis service")
            {
                ServiceTypeHourly.Click();
            }
            else if (Helpers.ExceLibHelper.ReadData(2, "ServiceType") == "One-off service")
            {
                ServiceTypeOnOff.Click();
            }
            #endregion

            #region Select Location Type
            // Location Type Selection

            if (ExceLibHelper.ReadData(2, "SelectLocationType") == "On-site")
            {
                LocationTypeOnsite.Click();
            }
            else if (ExceLibHelper.ReadData(2, "SelectLocationType") == "Online")
            {
                LocationTypeOnline.Click();
            }
            #endregion

            #region Select Available Dates from Calendar
            // Select Start Date
            //StartDate.SendKeys(ExceLibHelper.ReadData(2, "StartDate"));
            // Select End Date

            EndDate.SendKeys(ExceLibHelper.ReadData(2, "EndDate"));

            // select available days and start time and End time 

            // select available days and start time and End time   
            Thread.Sleep(3000);
            IList<IWebElement> Sttim = Driver.driver.FindElements(By.Name("StartTime"));

            IList<IWebElement> Edtim = Driver.driver.FindElements(By.Name("EndTime"));
            //Driver.driver.FindElements(By.Name("EndTime"));
            IList<IWebElement> Ckbx = Driver.driver.FindElements(By.XPath("(//input[@name='Available'])"));

            if (Ckbx.Count != 0)
            {
                //Selecting checkboxes for days from Monday to Friday
                for (int i = 1; i <= Ckbx.Count - 2; i++)
                {
                    //Verify whether checkbox is not selected
                    if (!Ckbx.ElementAt(i).Selected)
                    {
                        Ckbx.ElementAt(i).Click();

                    }
                    Console.WriteLine(Driver.driver);
                    //Validating the Count


                    Sttim.ElementAt(i).SendKeys(ExceLibHelper.ReadData(i + 1, "StartTime"));
                    // Sttim.ElementAt(i).SendKeys("10:00");


                    /*  var Svalue = Sttim.ElementAt(i).GetAttribute("value");
                       Console.WriteLine(Svalue);
                       Sttim.ElementAt(i).SendKeys(Svalue);*/

                    Thread.Sleep(2000);
                    // Sttim.ElementAt(i).Clear();
                    Edtim.ElementAt(i).SendKeys(ExceLibHelper.ReadData(i + 1, "EndTime"));
                    // Edtim.ElementAt(i).SendKeys("18:00");
                    Thread.Sleep(2000);

                }

            }



            #endregion
            #region Select Skill Trade
            // Select Skill Trade
            if (ExceLibHelper.ReadData(2, "SelectSkillTrade") == "Skill-exchange")
            {
                SkillExchange.Click();
                RequiredSkills.SendKeys(ExceLibHelper.ReadData(2, "ExchangeSkill"));
                RequiredSkills.SendKeys(Keys.Enter);
                RequiredSkills.SendKeys(ExceLibHelper.ReadData(3, "ExchangeSkill"));
                RequiredSkills.SendKeys(Keys.Enter);
            }
            else if (ExceLibHelper.ReadData(2, "SelectSkillTrade") == "Credit")
            {
                CreditAmount.Click();
                CreditAmount.SendKeys(ExceLibHelper.ReadData(2, "AmountInExchange"));
                CreditAmount.SendKeys(Keys.Enter);
            }
            #endregion

            #region Select User Status
            // Select User Status

            if (ExceLibHelper.ReadData(2, "UserStatus") == "Active")
            {
                StatusActive.Click();
            }
            else if (ExceLibHelper.ReadData(2, "UserStatus") == "Hidden")
            {
                StatusHidden.Click();
            }
            #endregion
        }
            public void ShareSave()
            {

                #region Save / Cancel Skill
                // Save or Cancel New Skill
                if (ExceLibHelper.ReadData(2, "SaveOrCancel") == "Save")
                {
                    Save.Click();
                }
                else if (ExceLibHelper.ReadData(2, "SaveOrCancel") == "Cancel")
                {
                    Cancel.Click();
                }
            }
            #endregion
         public void CheckSkill()
        { 
            Thread.Sleep(3000);
            #region Check whether New  skill created sucessfully      

            //String expectedValue = ExceLibHelper.ReadData(2, "title");
            String actualTitle = Driver.driver.Title;
            String currentURL = Driver.driver.Url;

            Console.WriteLine("Title of webpage is " + actualTitle);
            //string ShareSkillSucess = Driver.driver.FindElement(By.TagName("h2")).Text;
            Thread.Sleep(2000);
            if (actualTitle == "ListingManagement")
            {
                Assert.IsTrue(true);
                test.Log(Status.Pass, "Shared Skill Successful");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "AddShareSkill");

            }
            else
            {
                Console.WriteLine("Test failed");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "FailedAddShareSkill");
                test.Log(Status.Fail, "Share Skill Unsuccessful");
            }
            #endregion
        }


        #endregion

        #region Edit Skill
        public void EditSkill()
        {
            #region populate excel         

            //Populate the excel data            
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Managelisting");
            #endregion

            #region Enter Title 
            Title.WaitForElementClickable(Helpers.Driver.driver, 60);
            //Enter the data in Title textbox
            Title.SendKeys(ExceLibHelper.ReadData(2, "title"));
            #endregion

            #region Enter Description
            //Enter the data in Description textbox
            Description.SendKeys(ExceLibHelper.ReadData(2, "EnterDescription"));
            #endregion

            #region Category Drop Down

            // Click on Category Dropdown
            Category.Click();
            Thread.Sleep(1000);
            // Select Category from Category Drop Down
            var selectElement = new SelectElement(Category);
            selectElement.SelectByIndex(3);
            // Click on Sub-Category Dropdown
            SubCategory.Click();
            Thread.Sleep(1000);
            //Select Sub-Category from the Drop Down
            var SelectElement1 = new SelectElement(SubCategory);
            SelectElement1.SelectByIndex(4);
            #endregion

            #region Tags
            // Eneter Tag
            Tags.SendKeys(ExceLibHelper.ReadData(2, "TagName"));
            Tags.SendKeys(Keys.Enter);
            Tags.SendKeys(ExceLibHelper.ReadData(3, "TagName"));
            Tags.SendKeys(Keys.Enter);
            #endregion

            #region Service Type Selection
            // Service Type Selection
            if (ExceLibHelper.ReadData(2, "ServiceType") == "Hourly basis service")
            {
                ServiceTypeHourly.Click();
            }
            else if (ExceLibHelper.ReadData(2, "ServiceType") == "One-off service")
            {
                ServiceTypeOnOff.Click();
            }
            #endregion

            #region Select Location Type
            // Location Type Selection

            if (ExceLibHelper.ReadData(2, "SelectLocationType") == "On-site")
            {
                LocationTypeOnsite.Click();
            }
            else if (ExceLibHelper.ReadData(2, "SelectLocationType") == "Online")
            {
                LocationTypeOnline.Click();
            }
            #endregion

            #region Select Available Dates from Calendar
            // Select Start Date
            //StartDate.SendKeys(ExceLibHelper.ReadData(2, "StartDate"));
            // Select End Date
            EndDate.SendKeys(ExceLibHelper.ReadData(2, "EndDate"));

            // select available days and start time and End time 


            IList<IWebElement> Sttim = Driver.driver.FindElements(By.Name("StartTime"));
            IList<IWebElement> Edtim = Driver.driver.FindElements(By.Name("EndTime"));
            IList<IWebElement> Ckbx = Driver.driver.FindElements(By.XPath("(//input[@name='Available'])"));

            if (Ckbx.Count != 0)
            {
                //Selecting checkboxes for days from Monday to Friday
                for (int i = 1; i <= Ckbx.Count - 2; i++)
                {
                    //Verify whether checkbox is not selected
                    if (!Ckbx.ElementAt(i).Selected)
                    {
                        Ckbx.ElementAt(i).Click();

                    }
                    //Validating the Count

                    Sttim.ElementAt(i).SendKeys(ExceLibHelper.ReadData(i + 1, "StartTime"));
                    Thread.Sleep(2000);
                    Edtim.ElementAt(i).SendKeys(ExceLibHelper.ReadData(i + 1, "EndTime"));
                    Thread.Sleep(2000);

                }

            }

            #endregion
            #region Select Skill Trade
            // Select Skill Trade
            if (ExceLibHelper.ReadData(2, "SelectSkillTrade") == "Skill-exchange")
            {
                SkillExchange.Click();
                RequiredSkills.SendKeys(ExceLibHelper.ReadData(2, "ExchangeSkill"));
                RequiredSkills.SendKeys(Keys.Enter);
                RequiredSkills.SendKeys(ExceLibHelper.ReadData(3, "ExchangeSkill"));
                RequiredSkills.SendKeys(Keys.Enter);
            }
            else if (ExceLibHelper.ReadData(2, "SelectSkillTrade") == "Credit")

            {
                Credit.Click();
                CreditAmount.Click();
                string input = ExceLibHelper.ReadData(2, "AmountInExchange");

                int result = Int32.Parse(input);

                if (result >= 10)
                {
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "More than One digit not Possible");
                    test.Log(Status.Fail, "Two Digit not Added ");
                    Assert.Fail("Entering more than One digit not Possible");
                }
                else
                {
                    CreditAmount.SendKeys(ExceLibHelper.ReadData(2, "AmountInExchange"));
                    CreditAmount.SendKeys(Keys.Enter);
                }


            }
            #endregion

            #region Select User Status
            // Select User Status

            if (ExceLibHelper.ReadData(2, "UserStatus") == "Active")
            {
                StatusActive.Click();
            }
            else if (ExceLibHelper.ReadData(2, "UserStatus") == "Hidden")
            {
                StatusHidden.Click();
            }
            #endregion



            #region Save / Cancel Skill
            // Save or Cancel New Skill
            if (ExceLibHelper.ReadData(2, "SaveOrCancel") == "Save")
            {
                Save.Click();
            }
            else if (ExceLibHelper.ReadData(2, "SaveOrCancel") == "Cancel")
            {
                Cancel.Click();
            }
            #endregion

            Thread.Sleep(3000);
            #region Check whether New  skill updated sucessfully      

            //String expectedValue = ExceLibHelper.ReadData(2, "title");
            // Validate view listing through Page title
            String actualTitle = Driver.driver.Title;

            // Assert.AreEqual(actualTitle, "ListingManagement");

            if (actualTitle == "ListingManagement")
            {
                Assert.IsTrue(true);
                test.Log(Status.Pass, "Shared Skill Successful");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "AddShareSkill");

            }
            else
            {
                Console.WriteLine("Test failed");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "FailedAddShareSkill");
                test.Log(Status.Fail, "Share Skill Unsuccessful");
            }
            #endregion
        }
        #endregion
    }
}
    

