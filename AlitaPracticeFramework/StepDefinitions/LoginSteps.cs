using NUnit.Framework;
using TechTalk.SpecFlow;
using PageObjects.Login;
using Utilities.WebUtilities;

[Binding]
public class LoginSteps
{
    private LoginPage _loginPage;
    private WebUtilities _webUtilities;

    public LoginSteps(WebUtilities webUtilities)
    {
        _webUtilities = webUtilities;
        _loginPage = new LoginPage(_webUtilities);
    }

    [Given("I am on the login page")]
    public void GivenIAmOnTheLoginPage()
    {
        _webUtilities.NavigateGoToUrl("https://www.saucedemo.com/");
    }

    [When("I enter valid credentials")]
    public void WhenIEnterValidCredentials()
    {
        _loginPage.EnterUsername("standard_user");
        _loginPage.EnterPassword("secret_sauce");
    }

    [When("I enter invalid credentials")]
    public void WhenIEnterInvalidCredentials()
    {
        _loginPage.EnterUsername("invalid_user");
        _loginPage.EnterPassword("wrong_password");
    }

    [When("I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        _loginPage.ClickLoginButton();
    }

    [Then("I should be redirected to the inventory page")]
    public void ThenIShouldBeRedirectedToTheInventoryPage()
    {
        Assert.IsTrue(_webUtilities.FindElement(By.Id("inventory_container")).Displayed);
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        Assert.IsTrue(_loginPage.GetErrorMessage().Contains("error"));
    }
}