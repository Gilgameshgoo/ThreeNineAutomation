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
        IWebDriver driver;
        
        public CoreAutomationPage(IWebDriver driver) {
            this.driver = driver;           
        }
    }
}
