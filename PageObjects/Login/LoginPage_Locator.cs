// This partial class contains locators for the LoginPage
public partial class LoginPage {
    private IWebDriver _driver;
    public LoginPage(IWebDriver driver) {
        _driver = driver;
    }

    // Locators
    public By UsernameField => By.Id("user-name");
    public By PasswordField => By.Id("password");
    public By LoginButton => By.Id("login-button");
}