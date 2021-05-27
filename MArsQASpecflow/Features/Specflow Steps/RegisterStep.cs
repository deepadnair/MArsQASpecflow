using MArsQASpecflow.SpecflowPages.Pages.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MArsQASpecflow.Features.Specflow_Steps
{
    [Binding]
    public class RegisterStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        SignUp Obj = new SignUp();
        [Given(@"I press on Join Button")]
        public void GivenIPressOnJoinButton()
        {
            
            Obj.JoinLnk();
        }

        [Given(@"(.*) and (.*) entered")]
        public void GivenAndEntered(string FirstName, string LastName)
        {
            
            Obj.RegistName(FirstName,LastName);
        }

        [Given(@"(.*),\t(.*) and\t(.*)")]
        public void GivenAnd(string Email, string Password, string ConfirmPswd)
        {
            Obj.RegistMail(Email, Password, ConfirmPswd);
        }

        [Given(@"Enter the Terms CheckBox")]
        public void GivenEnterTheTermsCheckBox()
        {
            Obj.TermsCkBx();
        }

        [When(@"I press on Join Button")]
        public void WhenIPressOnJoinButton()
        {
            Obj.JnButtn();
        }

        [Then(@"I should be able to Register\.")]
        public void ThenIShouldBeAbleToRegister_()
        {
            Console.WriteLine("");
        }

    }
}
