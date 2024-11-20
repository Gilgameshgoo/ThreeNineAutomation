using AutomationCore.CoreTools;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.CoreTools.Elements;
using ThreeNineTests.CoreTests.PomPages;

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

            applicationPage.topBarPanel.lastMessageInChat.AssertContains(messageText);
            applicationPage.topBarPanel.userLoginInChat.AssertContains(receiverName);
            applicationPage.topBarPanel.appNameInChat.AssertContains(applicationName);

            return true;
        }
        public static bool OpenAdvPageFromChat(CoreChromeDriver driver, ApplicationPage applicationPage)
        {
            var applicationName = applicationPage.topBarPanel.appNameInChat.Text;
            applicationPage.topBarPanel.appNameInChat.Click();

            return driver.GetNumberofWindowsByTitle(applicationName) == 2;
        }

        private static string AddToFavorite(ApplicationPage applicationPage)
        {
            applicationPage.addToFavorite.Click();
            Wait.UntilTrue(() => applicationPage.deleteFromFavorite.Displayed, TimeSpan.FromSeconds(10));

            return applicationPage.applicationName.Text;
        }

        public static bool AddToFavoriteAndCheckFavoriteList(ApplicationPage applicationPage, CoreChromeDriver driver)
        {
            var advName = AddToFavorite(applicationPage);

            return HomePageActions.AdvNamePresentInFirstFavoriteItem(driver, advName);
        }
    }
}
