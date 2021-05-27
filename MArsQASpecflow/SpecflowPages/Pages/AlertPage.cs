using MArsQASpecflow.SpecflowPages.Helpers;
using OpenQA.Selenium;
using System;

using System.Collections.Generic;
using System.Text;

namespace MArsQASpecflow.SpecflowPages.Pages
{
    class AlertPage
    {
        private By AlertDialogBy = By.XPath("//div[@class='ns-box-inner']");
        public string getAlertDialogText()
        {
            WaitExtentions.WaitVisible(Driver.driver, AlertDialogBy, 2);
            var text = WaitExtentions.FindElement(Driver.driver, AlertDialogBy).Text;
            Console.WriteLine("text = " + text);
            return text;
        }
    }
}
