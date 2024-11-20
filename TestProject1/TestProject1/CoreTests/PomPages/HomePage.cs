using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;

namespace ThreeNineTests.CoreTests.PomPages
{
    public class HomePage : CoreAutomationPage
    {
        public IWebElement recomendedItem => driver.FindElement(By.XPath("//div[contains(@class,'recommended__item__title')]"));
        public IWebElement addAplication => driver.FindElement(By.Id("js-add-ad"));
        public WebElement personalCabinet => FindXpath("//div[@data-autotest='cabinet']");
        public IWebElement personalCabinetFavoriteList => personalCabinet.FindElement(By.XPath("//a[contains(@href,'favorites')]"));

        public TopBarPanel topBarPanel => new TopBarPanel(driver);
        public CategoriesPage categoriesPage => new CategoriesPage(driver);
        public ApplicationPage applicationpage => new ApplicationPage(driver);
        public HomePage(CoreChromeDriver driver) : base(driver)
        {

        }

    }
}
