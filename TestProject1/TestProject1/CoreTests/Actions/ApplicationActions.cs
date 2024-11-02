using ThreeNineTests.CoreTests.PomPages;
using ThreeNineTests.CoreTests.CoreTools;

namespace ThreeNineTests.CoreTests.Actions
{
    public static class ApplicationActions
    {
        public static bool SendMessage(CoreChromeDriver driver, ApplicationPage applicationPage)
        {   
            var messageText = "Hi, I am Josh Foreman" + new Random().Next(1, 1000);
            var receiverName = applicationPage.userLogin.Text.Trim();
            var applicationName = applicationPage.applicationName.Text.Trim();
            var pageUrl = driver.Url;

            applicationPage.messageArea.SendKeys(messageText);
            applicationPage.sendMessage.Click();

            TopBarPanelActions.OpenLastSentMessage(driver, applicationPage.topBarPanel);

            Assert.IsTrue(applicationPage.topBarPanel.lastMessageInChat.Text.Contains(messageText));
            Assert.IsTrue(applicationPage.topBarPanel.userLoginInChat.Text.Contains(receiverName));
            Assert.IsTrue(applicationPage.topBarPanel.appNameInChat.Text.Contains(applicationName));

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
