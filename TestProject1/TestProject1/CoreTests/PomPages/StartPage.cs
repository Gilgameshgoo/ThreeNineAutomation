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
    public class StartPage:CoreAutomationPage
    {
        public IWebElement emailInput => driver.FindElement(By.Name("login"));
        public IWebElement passwordInput => driver.FindElement(By.Name("password"));
        public IWebElement submitLogin => driver.FindElement(By.XPath("//button[@type='submit']"));
        public IWebElement mainLogo => driver.FindElement(By.XPath("//div[contains(@class,'header_bar_logo')]"));
        public TopBarPanel topBarPanel => new TopBarPanel(driver);
        public StartPage(CoreChromeDriver driver):base(driver) { 
            
        }
        
    }
}
