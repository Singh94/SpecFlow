using System;
using TechTalk.SpecFlow;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [Binding]
    public class SpecFlowFeature1Steps
    {

        ArrayList numbers = new ArrayList();
        int answer;
        decimal fAnswer;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            numbers.Add(p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            foreach (int num in numbers)
            {
                answer += num;
            }
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            answer = Convert.ToInt32(numbers[0]);

            for(int i = 1; i < numbers.Count; i++)
            {
                answer -= Convert.ToInt32(numbers[i]);
            }
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            answer = Convert.ToInt32(numbers[0]);
            for(int i = 1; i < numbers.Count; i++)
            {
                answer *= Convert.ToInt32(numbers[i]);
            }
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            fAnswer = Convert.ToInt32(numbers[0]);
            for(int i = 1; i < numbers.Count; i++)
            {
                fAnswer /= Convert.ToInt32(numbers[i]);
            }
        }

        [When(@"I press calculate")]
        public void WhenIPressCalculate()
        {
            int j = 0;
            for(int i = 0; i < numbers.Count-1; i++)
            {
                answer += Convert.ToInt32(numbers[i]);
                j = i;
            }
            answer -= Convert.ToInt32(numbers[j + 1]);
        }


        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, answer);;
        }

        [Then(@"the decimal result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(Decimal p0)
        {
            Assert.AreEqual(p0.ToString(), fAnswer.ToString("N6"));
        }


    }
}
