using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationCore.CoreTools;
using OpenQA.Selenium;

namespace ThreeNineTests.CoreTests.PomPages
{
    public class TopBarPanel:CoreAutomationPage
    {
        public IWebElement topBarIframe => driver.FindElement(By.Id("topbar-panel"));
        public IWebElement userNameButton => FindElementInFrameSwitch(By.Id("user-username-btn"), topBarIframe);
        public IWebElement loginButton => FindElementInFrameSwitch(By.Id("user-login"), topBarIframe);

        public TopBarPanel(IWebDriver driver):base(driver) {
            

        }       
    }
}
