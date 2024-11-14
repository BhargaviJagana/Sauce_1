using Utilities.WebUtilities;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        private WebUtilities _webUtilities;

        public LoginPage(WebUtilities webUtilities)
        {
            _webUtilities = webUtilities;
        }

        public void EnterUsername(string username)
        {
            _webUtilities.ClearAndSendKeys(UsernameField, username);
        }

        public void EnterPassword(string password)
        {
            _webUtilities.ClearAndSendKeys(PasswordField, password);
        }

        public void ClickLoginButton()
        {
            _webUtilities.Click(LoginButton);
        }

        public string GetErrorMessage()
        {
            return _webUtilities.FindElement(ErrorMessage).Text;
        }
    }
}