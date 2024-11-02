using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.PomPages.CategoriesPages.UpperCategories;

namespace ThreeNineTests.CoreTests.PomPages
{
    public class CategoriesPage : CoreAutomationPage
    {
        public IWebElement baseNode => driver.FindElement(By.XPath("//ul[contains(@class,'form-element')]"));
        public TransportCategoriePage Transport => new TransportCategoriePage(driver, GetCategoryButton("Transport"));

        public CategoriesPage(CoreChromeDriver driver):base(driver) {
            

        }

        private IWebElement GetCategoryButton(string categoryName) { 
            return baseNode.FindElement(By.XPath($"//a[contains(text(),'{categoryName}')]"));
        }


        
    }
}
