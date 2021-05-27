using MArsQASpecflow.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MArsQASpecflow.Features.Specflow_Steps
{
    [Binding]
    public sealed class ShareSkills_ManageList_Steps
    {
         ShareSkill Share = new ShareSkill();
         ManageListing Manage = new ManageListing();
        [Given(@"User Click on Share Skill Button fron Profile Page")]
        public void GivenUserClickOnShareSkillButtonFronProfilePage()
        {
            Share.NavSharSkill(); 
        }

        [Given(@"User enter the entire Required Fields")]
        public void GivenUserEnterTheEntireRequiredFields()
        {
            Share.AddNewSkill();
        }

        [When(@"User Click on Save Button to Add the Skills")]
        public void WhenUserClickOnSaveButtonToAddTheSkills()
        {
            Share.ShareSave();
        }
        [Then(@"Check whether New skills are created sucessfully")]
        public void ThenCheckWhetherNewSkillsAreCreatedSucessfully()
        {
            Share.CheckSkill();
        }

        [Given(@"User have Navigated to Manage Listing Page")]
        public void GivenUserHaveNavigatedToManageListingPage()
        {
            Manage.ManageList(); 
        }

        [Then(@"User Check on ActiveService")]
        public void ThenUserCheckOnActiveService()
        {
            Manage.ActiveService();
        }

        [Then(@"User Press Edit Icon which Navigates to Share Skill Page")]
        public void ThenUserPressEditIconWhichNavigatesToShareSkillPage()
        {
            Manage.EditServiceList();
        }

        [Then(@"User edit the fields and Click on Save Button")]
        public void ThenUserEditTheFieldsAndSaveButton()
        {
            Share.EditSkill();
        }

        [Then(@"Click on View Icon in Manage Listing page to see the changes\.")]
        public void ThenClickOnViewIconInManageListingPageToSeeTheChanges_()
        {
            Manage.ViewServiceList();
        }

        [Given(@"User is on  the Manage Listing Page")]
        public void GivenUserIsOnTheManageListingPage()
        {
            Manage.ManageList();
        }

        [Given(@"User Clicks  on Delete Icon")]
        public void GivenUserClicksOnDeleteIcon()
        {
            Manage.DeleteServiceList();
        }

        [Then(@"User should get an Alert for deletion")]
        public void ThenUserShouldGetAnAlertForDeletion()
        {
            Manage.DeleteAlert();
        }

        [Then(@"User should be able to Delete the Skill")]
        public void ThenUserShouldBeAbleToDeleteTheSkill()
        {
            Manage.DeleteVerification();
        }



    }
}
