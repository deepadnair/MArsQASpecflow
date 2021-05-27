using MArsQASpecflow.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MArsQASpecflow.SpecflowPages.Pages
{
    class Profile
    {
       

        public IWebElement ProfTab => Driver.driver.FindElement(By.LinkText("Profile"));

        public IWebElement Availtimeicon => Driver.driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/span[1]/i[1]"));
        public IWebElement Availhouricon => Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        public IWebElement AvailTargicon => Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        public IWebElement AvailTargetClose => Driver.driver.FindElement(By.XPath("//div[@class='four wide column']//div[4]//div[1]//span[1]//i[1]"));
        //  public IWebElement AvailDesicon => Driver.FindElement(By.CssSelector("h3[class='ui dividing header'] i[class='outline write icon']"));
        //Profile Description 
        public IWebElement AvailDesicon => Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        public IWebElement Descriptiontxt => Driver.driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
        public IWebElement BtnDesSave => Driver.driver.FindElement(By.CssSelector("button[type='button']"));
        //Profile Chat
        public IWebElement Chat => Driver.driver.FindElement(By.XPath(" //a[normalize-space()='Chat']"));
        // SearchSkills
        public IWebElement SrchSkill => Driver.driver.FindElement(By.XPath("(//input[@placeholder='Search skills'])[1]"));
        public IWebElement SrchIcon => Driver.driver.FindElement(By.XPath("(//i[@class='search link icon'])[1]"));
        public IWebElement RefSrchSkil => Driver.driver.FindElement(By.XPath("//div[@class='four wide column']//input[@placeholder='Search skills']"));
        public IWebElement RfSrchIcon => Driver.driver.FindElement(By.XPath("//div[@class='four wide column']//i[@class='search link icon']"));
        public IWebElement SearchUser => Driver.driver.FindElement(By.XPath("//input[@placeholder='Search user']"));
        // Change Password
        public IWebElement Chngpstab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));

        public IWebElement Chngpaslnk => Driver.driver.FindElement(By.LinkText("Change Password"));
        public IWebElement Chngpass => Driver.driver.FindElement(By.XPath("//a[text()='Change Password']"));

        public IWebElement Oldpass => Driver.driver.FindElement(By.XPath("//input[@name='oldPassword']"));
        public IWebElement Newpass => Driver.driver.FindElement(By.XPath("//input[@name='newPassword']"));

        public IWebElement Cnfmpass => Driver.driver.FindElement(By.XPath("//input[@name='confirmPassword']"));
        // click on save button
        public IWebElement PassSave => Driver.driver.FindElement(By.XPath("//button[@type='button' and text()='Save']"));

        public IWebElement ChatSearch => Driver.driver.FindElement(By.XPath("//input[@placeholder='Search']"));
        public IWebElement ChatMessage => Driver.driver.FindElement(By.XPath("//input[@id='chatTextBox']"));
        public IWebElement ChatMessend => Driver.driver.FindElement(By.XPath("//button[normalize-space()='Send']"));

        public void ClickProTab()

        {

            ProfTab.Click();
        }
        #region Availability
        public void AvailabiTimeLnk()
        {
            Thread.Sleep(3000);
            Availtimeicon.Click();
            }
        public void AvailableType()
        {
            var Worktype = Driver.driver.FindElement(By.Name("availabiltyType"));
            var selectElementh = new SelectElement(Worktype);
            selectElementh.SelectByValue("0");

            Thread.Sleep(5000);
        }
        #endregion

        #region Availablehour
        public void AvailabiHourLnk()
        {
            Availhouricon.Click();
        }
        public void AvailabilyHour()
        {
            Thread.Sleep(5000);
            var Workhour = Driver.driver.FindElement(By.Name("availabiltyHour"));
            var selectElementh = new SelectElement(Workhour);
            selectElementh.SelectByValue("0");
            Thread.Sleep(5000);
        }
        #endregion
        #region EarnTarget
        public void AvailabiTargetLnk()
        {
            Thread.Sleep(5000);
            AvailTargicon.Click();
        }
        public void AvailabilityTargt()
        {
            var Target = Driver.driver.FindElement(By.Name("availabiltyTarget"));
            var selectElementt = new SelectElement(Target);
            selectElementt.SelectByValue("0");
            Thread.Sleep(5000);

        }
        #endregion
        #region Add Description
        public void AvailabiDesLnk()
        {
            // AvailDesicon.WaitForElementClickable(Global.Base.driver, 60).Click();

            
            AvailDesicon.Click();

        }
        public void AvailableDescrip()
        {
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");

            Thread.Sleep(1000);
            Descriptiontxt.SendKeys(Keys.Control + "a");
            Descriptiontxt.SendKeys(Keys.Delete);
            Descriptiontxt.SendKeys(ExceLibHelper.ReadData(2, "Description"));
        }
        public void AvailableDescripsave()
        {
            BtnDesSave.Click();
            Thread.Sleep(5000);
            Driver.driver.SwitchTo().Window(Driver.driver.WindowHandles.Last());
            // verify Description is save successfully 
            Assert.AreEqual(Driver.driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "Description has been saved successfully");
            Driver.driver.SwitchTo().DefaultContent();

        }
#endregion
        #region  ChangePassword
        public void ChangePaswrdtab()
        {
            
            // Populate Login page test data collection
            // ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            Thread.Sleep(2000);
            // Navigate to change password page
            Chngpstab.Click();
            Thread.Sleep(2000);
            Chngpaslnk.Click();
        }
            public void ChangePassword()
            {
                ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
                Thread.Sleep(2000);
                Oldpass.SendKeys(ExceLibHelper.ReadData(2, "CurrentPassword"));
                Newpass.SendKeys(ExceLibHelper.ReadData(2, "NewPassword"));
                Thread.Sleep(2000);
                Cnfmpass.SendKeys(ExceLibHelper.ReadData(2, "CnfPassword"));
            }

           public void passavbtn()
            { 
            // click on save button
            PassSave.Click();
            Thread.Sleep(5000);
           
           }
        #endregion
        #region Chat in Profile
        public void Chatt() => Chat.Click();
        public void Chatsearch()
        {
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            Thread.Sleep(2000);
            ChatSearch.Click();
            ChatSearch.SendKeys(ExceLibHelper.ReadData(2, "Chatsearch"));
        }
        public void ChatsearchVisible()
        {
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            Thread.Sleep(2000);
            String Searchtxt = Driver.driver.FindElement(By.XPath("//div[normalize-space()='Deepa']")).Text; ;
            Assert.AreEqual(Searchtxt, ExceLibHelper.ReadData(2, "Chatsearch"));
           
        }
        public void ChatSend()
        {
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            Thread.Sleep(2000); 
            ChatMessage.Click();
            ChatMessage.SendKeys(ExceLibHelper.ReadData(2, "ChatMsg"));
            
        }
        public void ChatSendbtn()
        {
            ChatMessend.Click();

        }
        #endregion
        #region searchSkills
        public void SrchSkills()
        {
            // Populate Login page test data collection
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Search skills through type keys
            SrchSkill.SendKeys(ExceLibHelper.ReadData(2, "SearchSkills"));
            //click on search button
            SrchIcon.Click();
            Thread.Sleep(2000);
        }
            public void RefinSrchSkills()
            {
            // Populate Login page test data collection
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            RefSrchSkil.SendKeys(ExceLibHelper.ReadData(2, "RefineSearch"));
                RfSrchIcon.Click();
                Thread.Sleep(2000);
            }
        public void RefinSrchUser()
        {
            SearchUser.SendKeys(ExceLibHelper.ReadData(2, "SearchUser"));
            Thread.Sleep(3000);
            SearchUser.SendKeys(Keys.ArrowDown + Keys.Enter);
            Thread.Sleep(3000);
        }
        public void RefinSrchVisible()
        {
            string element = Driver.driver.FindElement(By.LinkText("Fast Track")).Text;
            Assert.AreEqual(element, ExceLibHelper.ReadData(2, "SearchUser"));

        }


        public void FilterSerachSkills()
        {
            // Populate Login page test data collection
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Search skills through type keys
           // SrchSkill.SendKeys(ExceLibHelper.ReadData(2, "SearchSkills"));
            //click on search button
          //  SrchIcon.Click();

          //  RefSrchSkil.SendKeys(ExceLibHelper.ReadData(2, "RefineSearch"));
         //   RfSrchIcon.Click();
            // Search skills using filter
            string value1 = ExceLibHelper.ReadData(2, "FilterButtons");
            string value2 = ExceLibHelper.ReadData(3, "FilterButtons");
            string value3 = ExceLibHelper.ReadData(4, "FilterButtons");
            // Click on button
            string Button = Driver.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]")).Text;


            Thread.Sleep(3000);
           
            for (int i = 1; i <= 3; i++)
            {
                // Click on ith button
                string actualvalue = Driver.driver.FindElement(By.XPath("//div/section/div/div[1]/div[5]/button[" + i + "]")).Text;
                if (actualvalue == value1)
                {
                    Thread.Sleep(3000);
                    Driver.driver.FindElement(By.XPath("//button[normalize-space()='Online']")).Click();
                    Console.WriteLine("Test Passed for Online Filter");
                    Thread.Sleep(2000);
                }
                else if (actualvalue == value2)
                {
                    Thread.Sleep(3000);
                    Driver.driver.FindElement(By.XPath("//button[normalize-space()='Onsite']")).Click();
                    Console.WriteLine("Test Passed for Onsite Filter");
                    Thread.Sleep(2000);
                }
                else if (actualvalue == value3)
                {
                    Thread.Sleep(3000);
                    Driver.driver.FindElement(By.XPath("//button[normalize-space()='ShowAll']")).Click();
                    Console.WriteLine("Test Passed for ShowAll Filter");
                    Thread.Sleep(2000);
                }
            }


        }
        #endregion
    }
}
