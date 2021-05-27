using MArsQASpecflow.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MArsQASpecflow.Features.Specflow_Steps
{
    [Binding]
    public  class SkillStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        SkillPage Skills = new SkillPage();

        [Given(@"The User Clicks on Skills Tab")]
        public void GivenTheUserClicksOnSkillsTab()
        {
            Skills.SkillsTab();
        }

        [When(@"the user Adds the New Skills details and Clicks on Add button")]
        public void WhenTheUserAddsTheNewSkillsDetailsAndClicksOnAddButton()
        {
            Skills.AddSkill();
        }

        [Then(@"the User should see the new Skills in his profile")]
        public void ThenTheUserShouldSeeTheNewSkillsInHisProfile()
        {
            Skills.ValidateAddSkill();
        }

        [Given(@"The User is on Skills Tab")]
        public void GivenTheUserIsOnSkillsTab()
        {
            Skills.SkillsTab();
        }

        [When(@"the user  Edits the Skills details and click on update button")]
        public void WhenTheUserEditsTheSkillsDetailsAndClickOnUpdateButton()
        {
            Skills.UpdateSkill();
        }

        [Then(@"the Skills Details should be Updated and should be seen by User")]
        public void ThenTheSkillsDetailsShouldBeUpdatedAndShouldBeSeenByUser()
        {
            Skills.ValidateUpdateSkill();
        }

        [When(@"the user deletes the Skills")]
        public void WhenTheUserDeletesTheSkills()
        {
            Skills.DeleteSkill();
        }

        [Then(@"the Skills details should be deleted\.")]
        public void ThenTheSkillsDetailsShouldBeDeleted_()
        {
            Skills.ValidateDelSkill();
        }

    }
}
