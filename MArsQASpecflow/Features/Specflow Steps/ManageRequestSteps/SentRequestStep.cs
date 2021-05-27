using MArsQASpecflow.SpecflowPages.Pages.ManageRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MArsQASpecflow.Features.Specflow_Steps.ManageRequestSteps
{
    [Binding]
    public  class SentRequestStep
    {

        SentRequests SdRqst = new SentRequests();
        ReceiveRequest RcRqst = new ReceiveRequest();

        [Given(@"The User Clicks ManageRequest tab")]
        public void GivenTheUserClicksManageRequestTab()
        {
            RcRqst.ManageRequest();
        }

        [Given(@"Select SentRequest DropDown")]
        public void GivenSelectSentRequestDropDown()
        {
            SdRqst.SenRequest();
        }

        [Then(@"If the Sender has not Accepted the Status will be pending\.")]
        public void ThenIfTheSenderHasNotAcceptedTheStatusWillBePending_()
        {
            SdRqst.PendStatus();
        }

        [Given(@"if User wants to withdraw, click on withdraw button")]
        public void GivenIfUserWantsToWithdrawClickOnWithdrawButton()
        {
            SdRqst.WithdrawSentRequest();
        }

        [Then(@"the Status should be Withdrawn")]
        public void ThenTheStatusShouldBeWithdrawn()
        {
            SdRqst.WithdrStatus();
        }
        [Given(@"if the Status is Accepted the Request is Accepted by Receiver")]
        public void GivenIfTheStatusIsAcceptedTheRequestIsAcceptedByReceiver()
        {
            SdRqst.Accepted();
        }

        [Given(@"Completed Button will be Visible")]
        public void GivenCompletedButtonWillBeVisible()
        {
            SdRqst.Cmpletebtn();
        }


        [Then(@"Click on Completed Button")]
        public void ThenClickOnCompletedButton()
        {
            SdRqst.Completed();
        }
        [Given(@"if the Status is Completed")]
        public void GivenIfTheStatusIsCompleted()
        {
            SdRqst.CompleteStatus();
        }

        [Then(@"Click on Review Button")]
        public void ThenClickOnReviewButton()
        {
            SdRqst.ReviewBtn();
        }

        [Then(@"Add Review Text and Ratings and Save\.")]
        public void ThenAddReviewTextAndRatingsAndSave_()
        {
            SdRqst.Review();
        }

        [Given(@"if the Status is Declined the Request is Declined")]
        public void GivenIfTheStatusIsDeclinedTheRequestIsDeclined()
        {
            SdRqst.DeclinStatus();
        }


    }
}
