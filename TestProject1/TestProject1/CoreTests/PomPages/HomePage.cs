using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.PomPages.ApplicationCategories;

namespace ThreeNineTests.CoreTests.PomPages
{
    public class HomePage:CoreAutomationPage
    {
        public IWebElement recomendedItem => driver.FindElement(By.XPath("//div[contains(@class,'recommended__item__title')]"));
        public IWebElement addAplication => driver.FindElement(By.Id("js-add-ad"));

        public TopBarPanel topBarPanel => new TopBarPanel(driver);
        public CategoriesPage categoriesPage => new CategoriesPage(driver);
        public ApplicationPage applicationpage => new ApplicationPage(driver);
        public HomePage(CoreChromeDriver driver):base(driver) { 
            
        }
        
    }
}
