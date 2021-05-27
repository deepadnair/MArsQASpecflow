using MArsQASpecflow.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MArsQASpecflow.Features.Specflow_Steps
{
    [Binding]
    public  class LanguageStep
    {


        Language Lang = new Language();
        [Given(@"The User Clicks on Language Tab")]
        public void GivenTheUserClicksOnLanguageTab()
        {
            Lang.LanguageTab();
        }

        [When(@"the user Adds the New Language details and Clicks on Add button")]
        public void WhenTheUserAddsTheNewLanguageDetailsAndClicksOnAddButton()
        {
            Lang.AddLang();
        }

        [Then(@"the User should see the new Language in his profile")]
        public void ThenTheUserShouldSeeTheNewLanguageInHisProfile()
        {
            Lang.ValidateAddedLang();
        }

        [Given(@"The User is on Language Tab")]
        public void GivenTheUserIsOnLanguageTab()
        {
            Lang.LanguageTab();
        }

        [When(@"the user  Edits the Language details and click on update button")]
        public void WhenTheUserEditsTheLanguageDetailsAndClickOnUpdateButton()
        {
            Lang.UpdateLang();
        }

        [Then(@"the Language Details should be Updated and should be seen by User")]
        public void ThenTheLanguageDetailsShouldBeUpdatedAndShouldBeSeenByUser()
        {
            Lang.ValidateUpdateLang();
        }
        [When(@"the user deletes the Language")]
        public void WhenTheUserDeletesTheLanguage()
        {
            Lang.DeleteLang();
        }

        [Then(@"the Language details should be deleted\.")]
        public void ThenTheLanguageDetailsShouldBeDeleted_()
        {
            Lang.ValidateDelLan();
        }

    }
}
