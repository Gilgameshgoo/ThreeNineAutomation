using AutomationCore.CoreTools;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using ThreeNineTests.CoreTests.CoreTools;

namespace ThreeNineTests.CoreTests.PomPages
{
    public class FavoriteListPage : CoreAutomationPage
    {
        public IWebElement userLogin => driver.FindElement(By.XPath("//a[contains(@class,'owner__login')]"));
        public IWebElement applicationName => driver.FindElement(By.XPath("//h1[@itemprop='name']"));
        public ReadOnlyCollection<WebElement> favoriteItemsListName => driver.FindElementss(By.XPath("//li[contains(@class,'favorites-item')]//a[contains(@class,'link js-item-ad')]"));
        //public ReadOnlyCollection<IWebElement> favoriteItemsListNamee => driver.FindElements(By.XPath("//li[contains(@class,'favorites-item')]//a[contains(@class,'link js-item-ad')]"));


        public TopBarPanel topBarPanel => new TopBarPanel(driver);

        public FavoriteListPage(CoreChromeDriver driver) : base(driver) { }
    }
}
