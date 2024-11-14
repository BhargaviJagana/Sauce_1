// This class wraps IWebDriver functionalities to provide easier usage throughout the framework.
public class WebUtilities {
    private IWebDriver _driver;

    public WebUtilities(IWebDriver driver) {
        _driver = driver;
    }

    // Example method
    public void NavigateTo(string url) {
        _driver.Navigate().GoToUrl(url);
    }

    // Add more methods as needed
}