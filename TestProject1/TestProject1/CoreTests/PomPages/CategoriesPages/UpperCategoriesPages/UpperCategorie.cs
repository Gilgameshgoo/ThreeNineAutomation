using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;

namespace ThreeNineTests.CoreTests.PomPages.ApplicationCategories
{
    public class UpperCategorie : CoreAutomationPage
    {   
        public UpperCategorie(CoreChromeDriver driver, IWebElement? categoryButton):base(driver) {
            if (categoryButton != null) { categoryButton.Click(); };          
        }

        protected IWebElement GetSubCategoryByHref(string subCategoryHref)
        {
            return driver.FindElement(By.XPath($"//li/a[contains(@href,'{subCategoryHref}')]"));
        }

    }
}
