using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.PomPages;

namespace ThreeNineTests.CoreTests.Actions
{
    public static class TopBarPanelActions
    {
        public static bool OpenLoginMenu(IWebDriver driver, StartPage startPage)
        {
            driver.SwitchTo().Frame(startPage.topBarPanel.topBarIframe);
            startPage.topBarPanel.loginButton.Click();
            driver.SwitchTo().ParentFrame();
            return Wait.UntilTrue(() => startPage.emailInput.Displayed, TimeSpan.FromSeconds(10));

        }

        public static bool OpenLastSentMessage(IWebDriver driver, TopBarPanel topBarPage)
        {
            driver.SwitchTo().Frame(topBarPage.topBarIframe);
            topBarPage.messageButton.Click();

            driver.SwitchTo().ParentFrame();
            Wait.Until(() => driver.SwitchTo().Frame(topBarPage.topBarChatIframe), TimeSpan.FromSeconds(20));
            Wait.Until(() => topBarPage.lastSentMessage.Click(), TimeSpan.FromSeconds(50));

            return Wait.UntilTrue(() => topBarPage.messageArea.Displayed, TimeSpan.FromSeconds(10));
        }
    }
}
