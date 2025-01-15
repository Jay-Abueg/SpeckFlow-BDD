using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YourProjectName.StepDefinitions 
{
    [Binding]
    public class SearchStepDefinitions
    {
        private IWebDriver _driver;  // Use IWebDriver for more flexibility
        private string _searchResultText;

        //You might need to configure your webdriver here or in the hooks

        [Given(@"User is on the landing page")]
        public void GivenUserIsOnTheLandingPage()
        {
            _driver = new ChromeDriver(); // Initialize your browser driver here.
            _driver.Navigate().GoToUrl("https://abr.business.gov.au/");
            _driver.Manage().Window.Maximize();
        }

        [When(@"User types '(.*)' on the search field")]
        public void WhenUserTypesOnTheSearchField(string searchText)
        {
           IWebElement searchInput = _driver.FindElement(By.Id("searchbox")); 
            searchInput.SendKeys(searchText);
        }

        [When(@"User clicks the search button")]
        public void WhenUserClicksTheSearchButton()
        {
            IWebElement searchButton = _driver.FindElement(By.Id("searchButton")); 
           searchButton.Click();
            
             //Wait for the results - you might need to implement waits using WebDriverWait
             _searchResultText = _driver.FindElement(By.Id("results")).Text; 
        }

        [Then(@"There should be result")]
        public void ThenThereShouldBeResult()
        {
            Assert.IsNotEmpty(_searchResultText);
            _driver.Quit();
        }
    }
}
