using MArsQASpecflow.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MArsQASpecflow.Features.Specflow_Steps
{
    [Binding]
    public  class EducationStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        Education Educate = new Education();

        [Given(@"The User Clicks on Education Tab")]
        public void GivenTheUserClicksOnEducationTab()
        {
            Educate.EducationTab();
        }
        [When(@"the user Adds the New Education details and Clicks on Add button")]
        public void WhenTheUserAddsTheNewEducationDetailsAndClicksOnAddButton()
        {
            Educate.AddEducation();
        }


             
       

        [When(@"the user Clicks on Add button then education details should be added")]
        public void WhenTheUserClicksOnAddButtonThenEducationDetailsShouldBeAdded()
        {
            Educate.ValidateAdd();
        }

       

        [Given(@"The User is on Education Tab")]
        public void GivenTheUserIsOnEducationTab()
        {
            Educate.EducationTab();
        }

        [When(@"the user  Edits the Education details and click on update button")]
        public void WhenTheUserEditsTheEducationDetailsAndClickOnUpdateButton()
        {
            Educate.UpdateEducation();
        }

        [Then(@"the Education Details should be Updated and should be seen by User")]
        public void ThenTheEducationDetailsShouldBeUpdatedAndShouldBeSeenByUser()
        {
            Educate.ValidateUpdate();
        }

        [When(@"the user deletes the Education")]
        public void WhenTheUserDeletesTheEducation()
        {
            Educate.DeleteEdu();
        }

        [Then(@"the Education details should be deleted\.")]
        public void ThenTheEducationDetailsShouldBeDeleted_()
        {
            Educate.ValidateDelete();
        }

    }
}
