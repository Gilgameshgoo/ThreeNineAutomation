using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium; 

namespace AutomationCore.CoreTools
{
    public class CoreAutomationPage
    {
        protected IWebDriver driver;
        
        public CoreAutomationPage(IWebDriver driver) {
            this.driver = driver;           
        }
        public IWebElement FindElementInFrameSwitch(By by, IWebElement frame) { 
            driver.SwitchTo().Frame(frame);
            var element = driver.FindElement(by);
            driver.SwitchTo().DefaultContent();
            return element;
        }
    }
}
