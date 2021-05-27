using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

using MArsQASpecflow.SpecflowPages.Pages;

namespace MArsQASpecflow.Features.Specflow_Steps
{
    [Binding]

        public  class CertificationStep
    {

        Certificate Cert = new Certificate();
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given(@"The User Clicks on Certificate Tab")]
        public void GivenTheUserClicksOnCertificateTab()
        {
            Cert.CertificateTab();
        }
        [When(@"the user Adds the New Certificate details and Clicks on Add button")]
        public void WhenTheUserAddsTheNewCertificateDetailsAndClicksOnAddButton()
        {
            Cert.AddCertificate();
        }


        
        [Then(@"the User should see the new Certificate in his profile")]
        public void ThenTheUserShouldSeeTheNewCertificateInHisProfile()
        {
            Cert.ValidateAdd();
        }

        [Given(@"The User is on Certificate Tab")]
        public void GivenTheUserIsOnCertificateTab()
        {
            Cert.CertificateTab();
        }

        [When(@"the user  Edits the Certificate details and click on update button")]
        public void WhenTheUserEditsTheCertificateDetailsAndClickOnUpdateButton()
        {
            Cert.UpdateCertificate();
        }


              

        [Then(@"the Details should be Updated and should be seen by User")]
        public void ThenTheDetailsShouldBeUpdatedAndShouldBeSeenByUser()
        {
            Cert.ValidateUpdate();
        }

        [Given(@"The User is on Certification Tab")]
        public void GivenTheUserIsOnCertificationTab()
        {
            Cert.CertificateTab();
        }



        [When(@"the user deletes the Certificate")]
        public void WhenTheUserDeletesTheCertificate()
        {
            Cert.DeleteCertificate();
        }

        [Then(@"the Certificate details should be deleted\.")]
        public void ThenTheCertificateDetailsShouldBeDeleted_()
        {
            Cert.ValidateDelete();
        }

    }
}
