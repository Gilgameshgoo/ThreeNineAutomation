using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;

namespace ThreeNineTests.CoreTests.PomPages
{
    public class ApplicationPage : CoreAutomationPage
    {
        public IWebElement userLogin => driver.FindElement(By.XPath("//a[contains(@class,'owner__login')]"));
        public IWebElement applicationName => driver.FindElement(By.XPath("//h1[@itemprop='name']"));
        public IWebElement messageArea => driver.FindElement(By.Id("js-ad-message-textarea"));
        public IWebElement sendMessage => driver.FindElement(By.XPath("//div[contains(@class,'message__send')]/button"));
        public IWebElement addToFavorite => driver.FindElement(By.XPath("//span[text()='Adăugă în favorite']"));
        public IWebElement deleteFromFavorite => driver.FindElement(By.XPath("//span[text()='Ștergeți din favorite']"));
        public TopBarPanel topBarPanel => new TopBarPanel(driver);

        public ApplicationPage(CoreChromeDriver driver) : base(driver) { }
    }
}
