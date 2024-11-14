using OpenQA.Selenium;

namespace Utilities.WebUtilities
{
    public class WebUtilities
    {
        private IWebDriver _driver;

        public WebUtilities(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateGoToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void Click(By locator)
        {
            _driver.FindElement(locator).Click();
        }

        public void ClearAndSendKeys(By locator, string text)
        {
            var element = _driver.FindElement(locator);
            element.Clear();
            element.SendKeys(text);
        }

        public IWebElement FindElement(By locator)
        {
            return _driver.FindElement(locator);
        }

        public IReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return _driver.FindElements(locator);
        }

        public void Quit()
        {
            _driver.Quit();
        }
    }
}