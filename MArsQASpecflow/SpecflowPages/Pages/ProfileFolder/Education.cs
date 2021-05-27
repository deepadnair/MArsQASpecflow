using MArsQASpecflow.SpecflowPages.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using static MArsQASpecflow.SpecflowPages.Helpers.CommonMethods;
using NUnit.Framework;

namespace MArsQASpecflow.SpecflowPages.Pages
{
    class Education
    {
        
        public Education()
        {
        }

        public IWebElement EdTab => Driver.driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']/a[3]"));
        public IWebElement AddEdu => Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        public IWebElement InstName => Driver.driver.FindElement(By.XPath("//input[@name ='instituteName']"));
        public IWebElement Degree => Driver.driver.FindElement(By.XPath("//input[@name='degree']"));
        public IWebElement AddDegrBtn => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
       
        
        public void EducationTab()
        {
            EdTab.Click();
        }
        
               
        public void AddEducation()
        {
            #region Add your Education
            // Populate Login page test data collection
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ProfileEducation");
            //click on Education tab
            
            IList<IWebElement> Tablerows = Driver.driver.FindElements(By.XPath("//div[3]/form/div[4]/div/div[2]/div/table/tbody/tr"));
            var rowCount = Tablerows.Count;
            for (int i = 1; i <= 3; i++)
            {
                //Click on Add New button
                AddEdu.Click();
                Thread.Sleep(3000);
                // Enter collage Name
                InstName.SendKeys(ExceLibHelper.ReadData(i + 1, "University"));
                // Select Country of College
                Thread.Sleep(3000);
                SelectElement selectcountry = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='country']")));
                selectcountry.SelectByValue(ExceLibHelper.ReadData(i + 1, "CountryOfCollege"));
                Thread.Sleep(3000);
                // Select Title
                SelectElement Title = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='title']")));
                Title.SelectByValue(ExceLibHelper.ReadData(i + 1, "Title"));
                Thread.Sleep(3000);
                //Enter the Degree
                Degree.SendKeys(ExceLibHelper.ReadData(i + 1, "Degree"));
                //Select the Year of Passing.
                SelectElement selectYear = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name= 'yearOfGraduation']")));
                selectYear.SelectByValue(ExceLibHelper.ReadData(i + 1, "YearOfPassing"));
                //Click on Add
                AddDegrBtn.Click();
                #endregion
            }

        }

        public void ValidateAdd()
        {
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ProfileEducation");
            String Educatn = Driver.driver.FindElement(By.XPath("//td[contains(text(),'B.Sc')]")).Text;
            String University = Driver.driver.FindElement(By.XPath("//td[contains(text(),'LBS College of Engineering')]")).Text;
            Assert.AreEqual(Educatn, ExceLibHelper.ReadData(2, "Title"));
            Assert.AreEqual(University, ExceLibHelper.ReadData(2, "University"));
            Console.WriteLine("Education" + " " + Educatn + " " +"from University" +" "+ University + "is added");

            String Educatn1 = Driver.driver.FindElement(By.XPath("//td[contains(text(),'M.Tech')]")).Text;
            String University1 = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Harvard')]")).Text;
            Assert.AreEqual(Educatn1, ExceLibHelper.ReadData(3, "Title"));
            Assert.AreEqual(University1, ExceLibHelper.ReadData(3, "University"));
            Console.WriteLine("Education" + " " + Educatn1 + " " + "from University" + " " + University1 + "is added");

            String Educatn2 = Driver.driver.FindElement(By.XPath("//td[contains(text(),'B.Tech')]")).Text;
            String University2 = Driver.driver.FindElement(By.XPath("//td[contains(text(),'ssssss')]")).Text;
            Assert.AreEqual(Educatn2, ExceLibHelper.ReadData(4, "Title"));
            Assert.AreEqual(University2, ExceLibHelper.ReadData(4, "University"));
            Console.WriteLine("Education" + " " + Educatn2 + " " + "from University" + " " + University2 + "is added");

        }

        /* public void AddBtn()
         {

             AddDegrBtn.Click();
             Thread.Sleep(3000);

         }*/

        public void UpdateEducation()
        {
            #region Update the given Education
            Thread.Sleep(3000);
            // Populate Login page test data collection  
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ProfileEducation");
            String expectedValue = ExceLibHelper.ReadData(2, "Title");
            //Get the table list
            IList<IWebElement> Tablerows = Driver.driver.FindElements(By.XPath("//div[3]/form/div[4]/div/div[2]/div/table/tbody/tr"));
            //Get the row count in table
            var rowCount = Tablerows.Count;
            for (int i = 1; i <= rowCount; i++)
            {
                //Get the xpath of ith row Title
                String actualValue = Driver.driver.FindElement(By.XPath("//div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]")).Text;
                //check if the editLanguage Parameter matches with ith row Title
                if (actualValue.Equals(expectedValue))
                {
                    //CliCk on Edit icon
                    Driver.driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[6]/span[1]/i")).Click();
                    //Send University name to update
                    IWebElement editRowValue = Driver.driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input"));
                    //Clear Previous text 
                    editRowValue.Clear();
                    editRowValue.SendKeys(ExceLibHelper.ReadData(i + 1, "UpdUniversity"));
                    // update Country of College
                    SelectElement selectcountry = new SelectElement(Driver.driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div[1]/div[2]/select")));
                    selectcountry.SelectByValue(ExceLibHelper.ReadData(i + 1, "UpdCountryOfCollege"));
                    // update Title
                    SelectElement Title = new SelectElement(Driver.driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div[2]/div[1]/select")));
                    Title.SelectByValue(ExceLibHelper.ReadData(i + 1, "UpdTitle"));
                    //update the Degree
                    IWebElement EditDegree = Driver.driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div[2]/div[2]/input"));
                    // Clear Previous text
                    EditDegree.Clear();
                    EditDegree.SendKeys(ExceLibHelper.ReadData(i + 1, "UpdDegree"));
                    //update the Year of Passing.
                    SelectElement selectYear = new SelectElement(Driver.driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div[2]/div[3]/select")));
                    selectYear.SelectByValue(ExceLibHelper.ReadData(i + 1, "UpdYearOfPassing"));

                    // Click on update button
                    Driver.driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div[3]/input[1]")).Click();
                    
                }
            }
            #endregion
        }
             public void ValidateUpdate()
                    {

            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ProfileEducation");
            #region validate updated Education
            try
                    {
                        //Start the Reports
                        test = extent.CreateTest("Edit Education");
                        test.Log(Status.Info, "Editing Education");
                        String expectedValue1 = ExceLibHelper.ReadData(2, "UpdTitle");
                        //Get the table list
                        IList<IWebElement> UpdatedTablerows = Driver.driver.FindElements(By.XPath("//div[3]/form/div[4]/div/div[2]/div/table/tbody/tr"));
                        //Get the row count in table
                        var UpdatedrowCount1 = UpdatedTablerows.Count;
                        for (var j = 1; j < UpdatedrowCount1; j++)
                        {
                            string actualValue1 = Driver.driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody[" + j + "]/tr/td[3]")).Text;

                            //Check if expected value is equal to actual value
                            if (expectedValue1 == actualValue1)
                            {
                                test.Log(Status.Pass, "Education updated Successful");
                                SaveScreenShotClass.SaveScreenshot(Driver.driver, "EditEducation");
                                Assert.IsTrue(true);
                            }
                            else
                                test.Log(Status.Fail, "Test Failed");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Thread.Sleep(3000);
            #endregion
        }




        //Delete a given Education
        public void DeleteEdu()
        {
            #region Delete given Education
            // Populate Login page test data collection
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ProfileEducation");
            String expectedValue = ExceLibHelper.ReadData(2, "DeleteUniversity");
            //Get the table row list
            IList<IWebElement> Tablerows = Driver.driver.FindElements(By.XPath("//div[3]/form/div[4]/div/div[2]/div/table/tbody/tr"));
            //Get the row count of table
            var rowCount = Tablerows.Count;
            for (int i = 1; i <= rowCount; i++)
            {
                //Get the xpath of ith row SkillName
                String actualValue = Driver.driver.FindElement(By.XPath("//div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;
                //check if the DeleteSkill parameter matches with ith Row SkillName
                if (actualValue == expectedValue)
                {
                    // Click on delete button
                    Driver.driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[6]/span[2]/i")).Click();

                }
            }
            #endregion
        }
            public void  ValidateDelete()
            {
            #region validate Deleted Education
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ProfileEducation");
            try
                {
                    //Start the Reports
                    test = extent.CreateTest("Delete Education");
                    test.Log(Status.Info, "Deleting Education");
                    String expectedValue1 = ExceLibHelper.ReadData(2, "DeleteUniversity");
                    //Get the table list
                    IList<IWebElement> UpdatedTablerows = Driver.driver.FindElements(By.XPath("//div[3]/form/div[4]/div/div[2]/div/table/tbody/tr"));
                    //Get the row count in table
                    var UpdatedrowCount1 = UpdatedTablerows.Count;
                    for (var j = 1; j < UpdatedrowCount1; j++)
                    {
                        string actualValue1 = Driver.driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody[" + j + "]/tr/td[2]")).Text;

                        //Check if expected value is equal to actual value
                        if (expectedValue1 != actualValue1)
                        {
                            test.Log(Status.Pass, "Education deleted Successful");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "DeleteEducation");
                            Assert.IsTrue(true);
                        }
                        else
                            test.Log(Status.Fail, "Test Failed");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Thread.Sleep(3000);
            }


        
    }
    #endregion
}
