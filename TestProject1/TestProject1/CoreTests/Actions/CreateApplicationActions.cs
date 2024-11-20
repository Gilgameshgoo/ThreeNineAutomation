using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.PomPages;

namespace ThreeNineTests.CoreTests.Actions
{
    public static class CreateApplicationActions
    {
        public static bool OpenMenuForCategory(CoreChromeDriver driver, ApplicationPage applicationPage)
        {
            var messageText = "Hi, I am Josh Foreman" + new Random().Next(1, 1000);
            var receiverName = applicationPage.userLogin.Text.Trim();
            var applicationName = applicationPage.applicationName.Text.Trim();
            var pageUrl = driver.Url;

            applicationPage.messageArea.SendKeys(messageText);
            applicationPage.sendMessage.Click();

            TopBarPanelActions.OpenLastSentMessage(driver, applicationPage.topBarPanel);

            Assert.That(applicationPage.topBarPanel.lastMessageInChat.Text.Contains(messageText));
            Assert.That(applicationPage.topBarPanel.userLoginInChat.Text.Contains(receiverName));
            Assert.That(applicationPage.topBarPanel.appNameInChat.Text.Contains(applicationName));

            return true;
        }
        public static bool OpenAppPageFromChat(CoreChromeDriver driver, ApplicationPage applicationPage)
        {
            var applicationName = applicationPage.topBarPanel.appNameInChat.Text;
            applicationPage.topBarPanel.appNameInChat.Click();

            return driver.GetNumberofWindowsByTitle(applicationName) == 2;
        }
    }
}
