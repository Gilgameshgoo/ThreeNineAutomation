using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.PomPages.CategoriesPages.UpperCategories;

namespace ThreeNineTests.CoreTests.PomPages
{
    public class CategoriesPage : CoreAutomationPage
    {
        public IWebElement baseNode => driver.FindElement(By.XPath("//ul[contains(@class,'form-element')]"));
        public TransportCategoriePage Transport => new(driver, GetSubCategoryByHref("=transport"));
        public ComputersAndOfficeCategoriePage ComputersAndOffice => new(driver, GetSubCategoryByHref("office-equipment"));

        public CategoriesPage(CoreChromeDriver driver) : base(driver) { }

        protected WebElement GetSubCategoryByHref(string subCategoryHref)
        {
            return (WebElement)driver.FindElement(By.XPath($"//li/a[contains(@href,'{subCategoryHref}')]"));
        }
    }
}
