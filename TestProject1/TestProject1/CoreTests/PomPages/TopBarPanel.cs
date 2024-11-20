using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;

namespace ThreeNineTests.CoreTests.PomPages
{
    public class TopBarPanel : CoreAutomationPage
    {
        public WebElement topBarIframe => FindId("topbar-panel");
        public WebElement topBarChatIframe => FindId("topbar-chat");
        public WebElement userNameButton => FindId("user-username-btn");
        public WebElement loginButton => FindId("user-login");
        public WebElement messageButton => FindXpath("//button[contains(@class,'item-btn-chat')]");
        public WebElement messageArea => FindId("simpalsid-chat-user-textarea");
        public WebElement lastSentMessage => FindXpath("//a[contains(@class,'chat-sidebar-contacts-item-btn')]");
        public WebElement lastMessageInChat => FindXpath("//div[contains(@class,'simpalsid-inner')]/span");
        public WebElement userLoginInChat => FindId("simpalsid-chat-user-info-alias");
        public WebElement appNameInChat => FindXpath("//div[contains(@class,'messages-message-object')]/a");

        public TopBarPanel(CoreChromeDriver driver) : base(driver) { }
    }
}
