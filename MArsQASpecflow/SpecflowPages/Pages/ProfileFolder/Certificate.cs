using MArsQASpecflow.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using AventStack.ExtentReports;
using static MArsQASpecflow.SpecflowPages.Helpers.CommonMethods;

namespace MArsQASpecflow.SpecflowPages.Pages
{
    public class Certificate
    {
        

        public Certificate()
        {
        }
        #region  Initialize Web Elements 
        public IWebElement CertTab => Driver.driver.FindElement(By.LinkText("Certifications"));
        //Click on Add New button
        public IWebElement AddCert => Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div/div[2]/div/table/thead/tr/th[4]/div"));
        // Enter Certificate Name
        public IWebElement CertNam => Driver.driver.FindElement(By.XPath("//input[@name ='certificationName']"));
        // Enter Certified from
        public IWebElement CertFrm => Driver.driver.FindElement(By.XPath("//input[@name ='certificationFrom']"));

        //Click on Add
        public IWebElement AddCerbtn => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        #endregion
        public void CertificateTab()
        {
            //Click on CertificateTab
            Thread.Sleep(3000);
            CertTab.Click();
        }
            public void AddCertificate()
            {
            #region Add Certificate
            // Populate Login page test data collection
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ProfileCertificate");

            for (int i = 1; i <= 3; i++)
            {
                //Click on Add New button
                AddCert.Click();
                Thread.Sleep(2000);
                // Enter Certificate Name
                CertNam.SendKeys(ExceLibHelper.ReadData(i + 1, "Certificate"));
                // Enter Certified from
                CertFrm.SendKeys(ExceLibHelper.ReadData(i + 1, "Certifiedfrom"));
                // Select Year
                SelectElement Title = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name ='certificationYear']")));
                Title.SelectByValue(ExceLibHelper.ReadData(i + 1, "Year"));
                AddCerbtn.Click();

            }

        }

       /* public void Addbtn()
        {
            //Click on Add
            AddCerbtn.Click();
            Thread.Sleep(3000);
        }*/
            public void ValidateAdd()
            {
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ProfileCertificate");
            String ActualCert = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Test Analyst')]")).Text;
            Assert.AreEqual(ActualCert, ExceLibHelper.ReadData(2, "Certificate"));
            Console.WriteLine("Certificate" + " " + ActualCert + " " + "is added");

            String ActualCert1 = Driver.driver.FindElement(By.XPath("//td[contains(text(),'ISTQB')]")).Text;
            Assert.AreEqual(ActualCert1, ExceLibHelper.ReadData(3, "Certificate"));
            Console.WriteLine("Certificate" + " " + ActualCert1 + " " + "is added");

            String ActualCert2 = Driver.driver.FindElement(By.XPath("//td[contains(text(),'ScrumMaster')]")).Text;
            Assert.AreEqual(ActualCert2, ExceLibHelper.ReadData(4, "Certificate"));
            Console.WriteLine("Certificate" + " " + ActualCert2 + " " + "is added");
            #endregion
        }
        public void UpdateCertificate()
        {
            #region Update the given Certificate

            Thread.Sleep(3000);
            // Populate Login page test data collection  
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ProfileCertificate");
            String expectedValue = ExceLibHelper.ReadData(2, "Certificate");
            Console.WriteLine("ExpectedValue is:" + expectedValue);
            //Get the table list
            IList<IWebElement> Tablerows = Driver.driver.FindElements(By.XPath("//form/div[5]/div[1]/div[2]/div/table/tbody/tr"));
            //Get the row count in table
            var rowCount = Tablerows.Count;
            for (var i = 1; i < rowCount; i++)
            //    for (int i = 1; i <= 6; i++)
            {
                //Get the xpath of ith row Certificate

                String actualValue = Driver.driver.FindElement(By.XPath("//form/div[5]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                Console.WriteLine("ActualValue is:" + actualValue);
                //check if the edit certificate Parameter matches with ith row Title
                if (actualValue.Equals(expectedValue))
                {
                    //CliCk on Edit icon
                    Driver.driver.FindElement(By.XPath("//form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[4]/span[1]/i")).Click();
                    // Update Certificate Name
                    IWebElement Certificate = Driver.driver.FindElement(By.XPath("//form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[1]/input"));
                    Certificate.Clear();
                    Certificate.SendKeys(ExceLibHelper.ReadData(2, "UpdCertificate"));
                    // Update Certified from
                    IWebElement CertifiedFrom = Driver.driver.FindElement(By.XPath("//form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[2]/input"));
                    CertifiedFrom.Clear();
                    CertifiedFrom.SendKeys(ExceLibHelper.ReadData(2, "UpdCertifiedFrom "));
                    // Update Year
                    SelectElement Year = new SelectElement(Driver.driver.FindElement(By.XPath("//form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[3]/select")));
                    Year.SelectByValue(ExceLibHelper.ReadData(2, "UpdYear"));
                    // Click on update button
                    Driver.driver.FindElement(By.XPath("//form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]")).Click();

                }
            }
            #endregion
        }
        public void ValidateUpdate()
        {
            #region validate updated Certificate

            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ProfileCertificate");
            try
                    {
                        //Start the Reports
                        test = extent.CreateTest("Edit Certificate");
                        test.Log(Status.Info, "Editing Certificate");
                        String expectedValue1 = ExceLibHelper.ReadData(2, "UpdCertificate");
                    //Get the table list
                      IList<IWebElement> UpdatedTablerows = Driver.driver.FindElements(By.XPath("//form/div[5]/div[1]/div[2]/div/table/tbody/tr"));
                    //Get the row count in table
                       var UpdatedrowCount1 = UpdatedTablerows.Count;
                        for (var j = 1; j<UpdatedrowCount1; j++)
                        {
                            string actualValue1 = Driver.driver.FindElement(By.XPath("//form/div[5]/div/div[2]/div/table/tbody[" + j + "]/tr/td[1]")).Text;

                            //Check if expected value is equal to actual value
                            if (expectedValue1 == actualValue1)
                            {
                                test.Log(Status.Pass, "Certificate updated Successful");
                                SaveScreenShotClass.SaveScreenshot(Driver.driver, "EditCertificate");
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
        #endregion

        //Delete a given Certificate

        public void DeleteCertificate()
        {
            #region Delete given Certificate
            Thread.Sleep(3000);
            // Populate Login page test data collection
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ProfileCertificate");
            String expectedValue = ExceLibHelper.ReadData(2, "DeleteCertificate");
            //Get the table row list
            IList<IWebElement> Tablerows = Driver.driver.FindElements(By.XPath("//form/div[5]/div/div[2]/div/table/tbody/tr"));
            //Get the row count of table
            var rowCount = Tablerows.Count;
            for (int i = 1; i <= rowCount; i++)
            {
                //Get the xpath of ith row Certificate name
                String actualValue = Driver.driver.FindElement(By.XPath("//form/div[5]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                //check if the DeleteCertificete parameter matches with ith Row CertificateName
                if (actualValue == expectedValue)
                {
                    // Click on delete button
                    Driver.driver.FindElement(By.XPath("//form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[4]/span[2]/i")).Click();

                }
            }
        }
            #endregion
            public void ValidateDelete()
            {
            #region validate Deleted Certificate
            ExceLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ProfileCertificate");
            try
                {
                    //Start the Reports
                    test = extent.CreateTest("Delete Certificate");
                    test.Log(Status.Info, "Deleting Certificate");
                    String expectedValue1 = ExceLibHelper.ReadData(2, "DeleteCertificate");
                    //Get the table list
                    IList<IWebElement> UpdatedTablerows = Driver.driver.FindElements(By.XPath("//form/div[5]/div/div[2]/div/table/tbody/tr"));
                    //Get the row count in table
                    var UpdatedrowCount1 = UpdatedTablerows.Count;
                    for (var j = 1; j < UpdatedrowCount1; j++)
                    {
                        string actualValue1 = Driver.driver.FindElement(By.XPath("//form/div[5]/div/div[2]/div/table/tbody[" + j + "]/tr/td[1]")).Text;

                        //Check if expected value is equal to actual value
                        if (expectedValue1 != actualValue1)
                        {
                            test.Log(Status.Pass, "Certificate deleted Successful");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "DeleteCertificate");
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


    

