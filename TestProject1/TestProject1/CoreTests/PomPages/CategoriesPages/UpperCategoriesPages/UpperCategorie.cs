using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;

namespace ThreeNineTests.CoreTests.PomPages.ApplicationCategories
{
    public class UpperCategorie : CoreAutomationPage
    {
        public UpperCategorie(CoreChromeDriver driver, IWebElement? categoryButton) : base(driver)
        {
            if (categoryButton != null) { categoryButton.Click(); };
        }

        protected WebElement GetSubCategoryByHref(string subCategoryHref)
        {
            return (WebElement)driver.FindElement(By.XPath($"//li/a[contains(@href,'{subCategoryHref}')]"));
        }

    }
}
