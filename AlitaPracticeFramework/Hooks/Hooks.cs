using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Utilities.WebUtilities;

namespace AlitaPracticeFramework.Hooks
{
    [Binding]
    public class Hooks
    {
        private IWebDriver _driver;
        private WebUtilities _webUtilities;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver();
            _webUtilities = new WebUtilities(_driver);
            ScenarioContext.Current["WebUtilities"] = _webUtilities;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}