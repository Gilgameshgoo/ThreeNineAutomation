using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.CoreTools.Elements;

namespace ThreeNineTests.CoreTests.PomPages.CategoriesPages.FinishedAdvPages
{
    public class BasicFinishedAdvPage : CoreAutomationPage
    {
        public WebElement title => FindXpath("//h1[@itemprop='name']");
        public WebElement price => FindXpath("(//span[@itemprop='price'])[1]");
        public WebElement description => FindXpath("//div[contains(@class,'description')]");
        public WebElement subCategory => FindXpath("//a[contains(@class,'category__link')]");
        public WebElement region => FindXpath("//dd[@itemprop = 'address'][2]");

        public BasicFinishedAdvPage(CoreChromeDriver driver) : base(driver) { }

        protected CoreSelect FindSelectByLang(string romanian, string russian)
        {
            return new CoreSelect(FindXpath($"//dl[contains(.,'{romanian}') or contains(.,'{russian}')]//select"));
        }
    }
}
