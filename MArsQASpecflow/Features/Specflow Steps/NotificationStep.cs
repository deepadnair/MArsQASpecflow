using MArsQASpecflow.SpecflowPages.Helpers;
using MArsQASpecflow.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MArsQASpecflow.Features.Specflow_feature
{
    [Binding]
    public  class NotificationStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        public string DashBoardUrl = "http://localhost:5000/Account/Dashboard";
        public string ProfileUrl = "http://localhost:5000/Account/Profile";

        Notification notificatn = new Notification();
        AlertPage Alert = new AlertPage();
        // notification = new Notification();



        [Given(@"the User is in Profile Page")]
        public void GivenTheUserIsInProfilePage()
        {
            Driver.driver.Navigate().GoToUrl(ProfileUrl);
        }

        [When(@"User Clicks on the Notification button")]
        public void WhenUserClicksOnTheNotificationButton()
        {
            notificatn.ClikNotificationBtn();
        }
        [Then(@"The Notification Page should be displayed")]
        public void ThenTheNotificationPageShouldBeDisplayed()
        {
            Assert.IsTrue(notificatn.getServiceReqTxt().Contains("Updated at"));
        }


        [Given(@"User Clicks on the Notification button")]
        public void GivenUserClicksOnTheNotificationButton()
        {
            notificatn.ClikNotificationBtn();
        }
        [When(@"Clicks on the Mark all as read button")]
        public void WhenClicksOnTheMarkAllAsReadButton()
        {
            notificatn.ClikMrkAllAsReadBtn();
        }

        [Then(@"The numbers of notification should be Cleared")]
        public void ThenTheNumbersOfNotificationShouldBeCleared()
        {
            Assert.IsTrue(!notificatn.isNumberVisible());
        }

        [When(@"Clicks on the See all button")]
        public void WhenClicksOnTheSeeAllButton()
        {
            notificatn.ClikSeeAllBtn();
        }

        [Then(@"The user should be able to navigate to the dashboard Page")]
        public void ThenTheUserShouldBeAbleToNavigateToTheDashboardPage()
        {
            Assert.AreEqual(DashBoardUrl, Driver.driver.Url);
        }

       


        [Given(@"Clicks on the See all button")]
        public void GivenClicksOnTheSeeAllButton()
        {
            notificatn.ClikSeeAllBtn();
        }
        

        [Given(@"Clicks on the Load More button")]
        public void GivenClicksOnTheLoadMoreButton()
        {
            notificatn.ClikLoadMoreButton();
        }
        [Then(@"The Show Less button should be displayed")]
        public void ThenTheShowLessButtonShouldBeDisplayed()
        {
            Assert.IsTrue(notificatn.isShowLessBtnVisible());
        }

        [When(@"User Clicks on the Show Less button")]
        public void WhenUserClicksOnTheShowLessButton()
        {
            notificatn.ClikShowLessBtn();
        }
        [Then(@"The Show Less button should be not displayed")]
        public void ThenTheShowLessButtonShouldBeNotDisplayed()
        {
            Assert.IsTrue(!notificatn.isShowLessBtnVisible());
        }

        [Given(@"Ticks a notification item")]
        public void GivenTicksANotificationItem()
        {
            notificatn.TikNotifictnItem(0);
        }

        [When(@"User Clicks on the Delete Selection icon")]
        public void WhenUserClicksOnTheDeleteSelectionIcon()
        {
            notificatn.ClickDelectSelectionButton();
        }

        [Then(@"The notification Item should be deleted")]
        public void ThenTheNotificationItemShouldBeDeleted()
        {
            Assert.AreEqual("Notification updated", Alert.getAlertDialogText());
        }


        [Given(@"Ticks more than one notification items")]
        public void GivenTicksMoreThanOneNotificationItems()
        {
            notificatn.TikNotifictnItem(0);
            notificatn.TikNotifictnItem(1);
        }

        [When(@"User Click on the Delete Selection icon")]
        public void WhenUserClickOnTheDeleteSelectionIcon()
        {
            notificatn.ClickDelectSelectionButton();
        }
        [Then(@"The notification Items should be deleted")]
        public void ThenTheNotificationItemsShouldBeDeleted()
        {
            Assert.AreEqual("Notification updated", Alert.getAlertDialogText());
        }


        [Given(@"Clicks on Select All icon")]
        public void GivenClicksOnSelectAllIcon()
        {
            notificatn.SeltAllSerReqts();
        }

        

        [Then(@"All of the notification items should be deleted")]
        public void ThenAllOfTheNotificationItemsShouldBeDeleted()
        {
            Assert.AreEqual("Notification updated", Alert.getAlertDialogText());
           
        }
        [Given(@"Clicks on Select All")]
        public void GivenClicksOnSelectAll()
        {
            notificatn.SeltAllSerReqts();
        }


        [Then(@"The notification item should be marked as read")]
        public void ThenTheNotificationItemShouldBeMarkedAsRead()
        {
            notificatn.MrkAsReadAssertn();
        }

        [When(@"User Clicks on Mark Selection as Read")]
        public void WhenUserClicksOnMarkSelectionAsRead()
        {
            notificatn.ClikSelAllBtn();
        }

        [Then(@"All notifications selected should be marked as read")]
        public void ThenAllNotificationsSelectedShouldBeMarkedAsRead()
        {
            notificatn.MrkAsReadAssertn();
        }

        
        [When(@"Click on Select all")]
        public void WhenClickOnSelectAll()
        {
            notificatn.SeltAllSerReqts();
        }

        [Then(@"All notifications should be selected")]
        public void ThenAllNotificationsShouldBeSelected()
        {
            notificatn.AllSerReqtsSeletdAssertn();
        }

        [Given(@"Click on Select all")]
        public void GivenClickOnSelectAll()
        {
            notificatn.SeltAllSerReqts();
        }

        [When(@"Click on Unselect all")]
        public void WhenClickOnUnselectAll()
        {
            notificatn.UnselectAllRequests();
        }

        [Then(@"All notifications should be unselected")]
        public void ThenAllNotificationsShouldBeUnselected()
        {
            notificatn.UnseltAllAssertn();
        }



    }
}
