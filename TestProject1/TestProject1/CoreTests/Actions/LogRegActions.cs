using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.ConfigUser;
using ThreeNineTests.CoreTests.PomPages;

namespace ThreeNineTests.CoreTests.Actions
{
    public static class LogRegActions
    {
        public static TopBarPanel Login(IWebDriver driver, UserJsonMap user)
        {
            var startPage = new StartPage(driver);
            startPage.topBarPanel.loginButton.Click();
            Wait.UntilTrue(() => startPage.emailInput.Displayed, TimeSpan.FromSeconds(10));

            startPage.emailInput.SendKeys(user.Email);
            startPage.passwordInput.SendKeys(user.Password);
            startPage.submitLogin.Click();

            Wait.UntilTrue(() => startPage.topBarPanel.userNameButton.Text.Contains(user.NickName), TimeSpan.FromSeconds(10));

            return startPage.topBarPanel;
        }
    }
}
