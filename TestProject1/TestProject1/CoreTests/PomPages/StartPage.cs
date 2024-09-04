using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationCore.CoreTools;
using OpenQA.Selenium;

namespace ThreeNineTests.CoreTests.PomPages
{
    public class StartPage:CoreAutomationPage
    {
        public IWebElement emailInput => driver.FindElement(By.Name("login"));
        public IWebElement passwordInput => driver.FindElement(By.Name("password"));
        public IWebElement submitLogin => driver.FindElement(By.XPath("//button[@type='submit']"));
        public TopBarPanel topBarPanel => new TopBarPanel(driver);
        public StartPage(IWebDriver driver):base(driver) { 
            
        }
        
    }
}
