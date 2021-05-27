using MArsQASpecflow.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MArsQASpecflow.Features.Specflow_Steps
{
    [Binding]
    public class ProfileStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        Profile Profle = new Profile();

        [Given(@"User is on Profile Tab")]
        public void GivenUserIsOnProfileTab()
        {
            Profle.ClickProTab();
        }

        [Given(@"User Clicks on Availabiltytimelink")]
        public void GivenUserClicksOnAvailabiltytimelink()
        {
            Profle.AvailabiTimeLnk();
        }

        [Then(@"Choose one option from the dropdown\.")]
        public void ThenChooseOneOptionFromTheDropdown_()
        {
            Profle.AvailableType();
        }

        [Given(@"User Clicks on AvailabiltyHourlink")]
        public void GivenUserClicksOnAvailabiltyHourlink()
        {
            Profle.AvailabiHourLnk();
        }

        [Then(@"Choose one hour option from the dropdown\.")]
        public void ThenChooseOneHourOptionFromTheDropdown_()
        {
            Profle.AvailabilyHour();
        }

        [Given(@"User Clicks on EarnTargetlink")]
        public void GivenUserClicksOnEarnTargetlink()
        {
            Profle.AvailabiTargetLnk();
        }

        [Then(@"Choose one Target option from the dropdown\.")]
        public void ThenChooseOneTargetOptionFromTheDropdown_()
        {
            Profle.AvailabilityTargt();
        }

        [Given(@"User Clicks on Descriptiontab")]
        public void GivenUserClicksOnDescriptiontab()
        {
            Profle.AvailabiDesLnk();
        }

        [Given(@"User adds Description text")]
        public void GivenUserAddsDescriptionText()
        {
            Profle.AvailableDescrip();
        }

        [Then(@"Savethe description and Verify the details")]
        public void ThenSavetheDescriptionAndVerifyTheDetails()
        {
            Profle.AvailableDescripsave();
        }

        [Given(@"the user is on Profile tab")]
        public void GivenTheUserIsOnProfileTab()
        {
            Profle.ClickProTab();
        }

        [Given(@"the user Clicks on User tab and changepassword link")]
        public void GivenTheUserClicksOnUserTabAndChangepasswordLink()
        {
            Profle.ChangePaswrdtab();
        }

        [Given(@"the user inputs current password,new password and confirmpassword")]
        public void GivenTheUserInputsCurrentPasswordNewPasswordAndConfirmpassword()
        {
           Profle.ChangePassword();
        }

        [Given(@"Clicks on save button the details are saved")]
        public void GivenClicksOnSaveButtonTheDetailsAreSaved()
        {
            Profle.passavbtn();
        }

        [Given(@"the user Clicks on Chat tab Chat screen opens")]
        public void GivenTheUserClicksOnChatTabChatScreenOpens()
        {
            Profle.Chatt();
        }

        [When(@"the user inputs name in search input box")]
        public void WhenTheUserInputsNameInSearchInputBox()
        {
            Profle.Chatsearch();
        }

        [Then(@"Chats between the input name and user should be visible")]
        public void ThenChatsBetweenTheInputNameAndUserShouldBeVisible()
        {
            Profle.ChatsearchVisible();
        }

        [Then(@"to send message add message in input box")]
        public void ThenToSendMessageAddMessageInInputBox()
        {
            Profle.ChatSend();
        }

        [Then(@"Clicks on send button")]
        public void ThenClicksOnSendButton()
        {
            Profle.ChatSendbtn();
        }

        [Given(@"the user inputs search key in search inputbox and click on searchicon")]
        public void GivenTheUserInputsSearchKeyInSearchInputboxAndClickOnSearchicon()
        {
            Profle.SrchSkills();
        }

        [When(@"the user input search key Refine search and click on searchicon")]
        public void WhenTheUserInputSearchKeyRefineSearchAndClickOnSearchicon()
        {
            Profle.RefinSrchSkills();
        }

        [When(@"the user input search user key search user and click on searchicon")]
        public void WhenTheUserInputSearchUserKeySearchUserAndClickOnSearchicon()
        {
            Profle.RefinSrchUser();
        }

        [Then(@"the refined search items should be Displayed")]
        public void ThenTheRefinedSearchItemsShouldBeDisplayed()
        {
            Profle.RefinSrchVisible();
        }

        [When(@"add  any of the filters the filtered search should be displayed")]
        public void WhenAddAnyOfTheFiltersTheFilteredSearchShouldBeDisplayed()
        {
            Profle.FilterSerachSkills();
        }

    }
}
