using System;
using TechTalk.SpecFlow;
using System.Collections;

namespace UnitTest1
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        ArrayList number = new ArrayList();
        decimal answer;

        [Given(@"I entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            number.Add(p0);
        }

        [Given(@"I split numbers into arrays")]
        public void GivenISplitNumbersIntoArrays()
        {
            for (int i = 0; i < number.Count; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    ArrayList arrayList = new ArrayList();
                }
            }
        }


        [When(@"I press calculation")]
        public void WhenIPressCalculation()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
