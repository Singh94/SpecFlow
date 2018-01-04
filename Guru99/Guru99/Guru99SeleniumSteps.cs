using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using System;
using OpenQA.Selenium.Support.UI;

namespace Guru99
{
    [Binding]
    public class Guru99SeleniumSteps
    {

        RemoteWebDriver driver;

        [Given(@"I open firefox")]
        public void GivenIOpenFirefox()
        {
            driver = new FirefoxDriver(Environment.CurrentDirectory + "\\..\\Guru99\\Resources");
        }

        [Given(@"I go to ""(.*)""")]
        public void GivenIGoTo(string p0)
        {
            driver.Url = p0;
        }

        [When(@"I enter username of ""(.*)""")]
        public void WhenIEnterUsernameOf(string p0)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(250));
            IWebElement username = wait.Until(driver => driver.FindElement(By.XPath("/html/body/form/table/tbody/tr[1]/td[2]/input")));

            username.SendKeys(p0);
        }

        [When(@"I enter password of ""(.*)""")]
        public void WhenIEnterPasswordOf(string p0)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(250));
            IWebElement password = wait.Until(driver => driver.FindElement(By.XPath("/html/body/form/table/tbody/tr[2]/td[2]/input")));

            password.SendKeys(p0);
        }


        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(250));
            IWebElement loginButtonClick = wait.Until(driver => driver.FindElement(By.XPath("/html/body/form/table/tbody/tr[3]/td[2]/input[1]")));

            loginButtonClick.Click();
        }

        [Then(@"I should be logged-in with success message ""(.*)""")]
        public void ThenIShouldBeLogged_InWithSuccessMessage(string p0)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(250));
            IWebElement loginSuccess = wait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[2]/td/marquee")));
;
            string login = loginSuccess.Text;
            Assert.AreEqual(login, p0);
        }


        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            driver.Close();
        }
    }
}
