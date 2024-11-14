using TechTalk.SpecFlow;

[Binding]
public class LoginSteps {
    private LoginPage _loginPage;

    public LoginSteps(LoginPage loginPage) {
        _loginPage = loginPage;
    }

    [Given("I am on the login page")]
    public void GivenIAmOnTheLoginPage() {
        _loginPage.NavigateTo("https://www.saucedemo.com/");
    }

    [When("I enter valid credentials")]
    public void WhenIEnterValidCredentials() {
        _loginPage.EnterUsername("standard_user");
        _loginPage.EnterPassword("secret_sauce");
    }

    [When("I enter invalid credentials")]
    public void WhenIEnterInvalidCredentials() {
        _loginPage.EnterUsername("invalid_user");
        _loginPage.EnterPassword("wrong_password");
    }

    [Then("I should be redirected to the homepage")]
    public void ThenIShouldBeRedirectedToTheHomepage() {
        // Assert homepage is displayed
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage() {
        // Assert error message is displayed
    }
}