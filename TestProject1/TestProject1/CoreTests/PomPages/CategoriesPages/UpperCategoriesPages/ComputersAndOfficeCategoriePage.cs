using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.PomPages.ApplicationCategories;
using ThreeNineTests.CoreTests.PomPages.CategoriesPages.CreateAdvPages;

namespace ThreeNineTests.CoreTests.PomPages.CategoriesPages.UpperCategories
{
    public class ComputersAndOfficeCategoriePage : UpperCategorie
    {
        public MonitorCreateAdvPage Monitor => new MonitorCreateAdvPage(driver, MonitorButton);
        public WebElement MonitorButton => GetSubCategoryByHref("/monitors");

        public ComputersAndOfficeCategoriePage(CoreChromeDriver driver, IWebElement? categoryButton) : base(driver, categoryButton) { }
    }
}
