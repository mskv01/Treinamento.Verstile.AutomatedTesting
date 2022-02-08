using System;
using TechTalk.SpecFlow;

namespace Treinamento.Versatile.UIAutomatedTesting.StepDefinitions
{
    [Binding]
    public class RegisterUserSteps
    {
        [Given(@"that the user wants to create an account")]
        public void GivenThatTheUserWantsToCreateAnAccount()
        {
            throw new PendingStepException();
        }

        [Given(@"that the user inform the necessary data for registration ""([^""]*)"" ""([^""]*)"" ""([^""]*)""")]
        public void GivenThatTheUserInformTheNecessaryDataForRegistration(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [Then(@"the user is informed that mandatory registration fields have not been filled out ""([^""]*)"" ""([^""]*)"" ""([^""]*)""")]
        public void ThenTheUserIsInformedThatMandatoryRegistrationFieldsHaveNotBeenFilledOut(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [Given(@"that the user inform the necessary data for registration")]
        public void GivenThatTheUserInformTheNecessaryDataForRegistration(Table table)
        {
            throw new PendingStepException();
        }

        [Then(@"the user is informed that there is already a registered record for this email")]
        public void ThenTheUserIsInformedThatThereIsAlreadyARegisteredRecordForThisEmail()
        {
            throw new PendingStepException();
        }

        [Given(@"that the user inform the necessary data for registration")]
        public void GivenThatTheUserInformTheNecessaryDataForRegistration()
        {
            throw new PendingStepException();
        }

        [Then(@"the user is informed that the registration was successful")]
        public void ThenTheUserIsInformedThatTheRegistrationWasSuccessful()
        {
            throw new PendingStepException();
        }
    }
}
