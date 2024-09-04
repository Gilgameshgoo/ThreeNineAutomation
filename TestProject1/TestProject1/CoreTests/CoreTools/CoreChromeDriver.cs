using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeNineTests.CoreTests.CoreTools
{
    public class CoreChromeDriver: ChromeDriver
    {
        public IWebElement FindElementInFrame(By by, IWebElement frame)
        {
            SwitchTo().Frame(frame);
            var element = FindElement(by);
            return element;
        }
    }
}
