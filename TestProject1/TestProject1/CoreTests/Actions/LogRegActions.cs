using AutomationCore.CoreTools;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.Data.DataMappers;
using ThreeNineTests.CoreTests.PomPages;

namespace ThreeNineTests.CoreTests.Actions
{
    public static class LogRegActions
    {
        public static HomePage Login(CoreChromeDriver driver, UserJsonMap user)
        {

            var startPage = new StartPage(driver);
            TopBarPanelActions.OpenLoginMenu(driver, startPage);

            startPage.emailInput.SendKeys(user.Email);
            startPage.passwordInput.SendKeys(user.Password);
            startPage.submitLogin.Click();

            driver.SwitchTo().Frame(startPage.topBarPanel.topBarIframe);
            var loggedIn = Wait.UntilTrue(() => startPage.topBarPanel.userNameButton.Text.Contains(user.NickName), TimeSpan.FromSeconds(15));
            driver.SwitchTo().DefaultContent();

            return new HomePage(driver);
        }
    }
}
