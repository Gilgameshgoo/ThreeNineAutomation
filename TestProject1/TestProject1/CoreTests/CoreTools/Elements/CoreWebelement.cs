using OpenQA.Selenium;

namespace ThreeNineTests.CoreTests.CoreTools.Elements
{
    public class CoreWebelement : WebElement
    {
        IWebDriver driver;
        public CoreWebelement(WebDriver parentDriver, string id, By? parentFrame = null) : base(parentDriver, id)
        {
            driver = parentDriver;
        }
        public void ClickJS()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].click();", this);         
        }
    }
}
