using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;

namespace ThreeNineTests.CoreTests.PomPages
{
    public class TopBarPanel:CoreAutomationPage
    {
        public IWebElement topBarIframe => driver.FindElement(By.Id("topbar-panel"));
        public IWebElement topBarChatIframe => driver.FindElement(By.Id("topbar-chat"));
        public IWebElement userNameButton => driver.FindElement(By.Id("user-username-btn"));
        public IWebElement loginButton => driver.FindElement(By.Id("user-login"));
        public IWebElement messageButton => driver.FindElement(By.XPath("//button[contains(@class,'item-btn-chat')]"));
        public IWebElement messageArea => driver.FindElement(By.Id("simpalsid-chat-user-textarea"));
        public IWebElement lastSentMessage => driver.FindElement(By.XPath("//a[contains(@class,'chat-sidebar-contacts-item-btn')]"));
        public IWebElement lastMessageInChat => driver.FindElement(By.XPath("//div[contains(@class,'simpalsid-inner')]/span"));
        public IWebElement userLoginInChat => driver.FindElement(By.Id("simpalsid-chat-user-info-alias"));
        public IWebElement appNameInChat => driver.FindElement(By.XPath("//div[contains(@class,'messages-message-object')]/a"));

        public TopBarPanel(CoreChromeDriver driver):base(driver) {
            

        }


        
    }
}
