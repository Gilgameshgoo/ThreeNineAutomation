using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.PomPages.ApplicationCategories;
using ThreeNineTests.CoreTests.PomPages.CategoriesPages.CreateAdvPages;

namespace ThreeNineTests.CoreTests.PomPages.CategoriesPages.UpperCategories
{
    public class TransportCategoriePage : UpperCategorie
    {
        public CarsCreateAsdvPage Cars => new CarsCreateAsdvPage(driver, GetSubCategoryByHref("/cars"));
        public IWebElement Buses => GetSubCategoryByHref("/buses-and-minibuses");
        public IWebElement Trucks => FindId("/trucks");

        public TransportCategoriePage(CoreChromeDriver driver, IWebElement? categoryButton) : base(driver, categoryButton) { }
    }
}
