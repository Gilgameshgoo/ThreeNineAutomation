using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;

namespace ThreeNineTests.CoreTests.PomPages.CategoriesPages.FinishedAdvPages
{
    public class FinishedMonitorAdvPage : BasicFinishedAdvPage
    {
        public WebElement manufmanufacturer => FindXpath("//span[contains(text(),'Producător')]/following-sibling::span[contains(@class,'value')]");
        public WebElement screenDiagonal => FindXpath("//span[contains(text(),'Diagonala')]/following-sibling::span[contains(@class,'value')]");
        public WebElement screenResolution => FindXpath("//span[contains(text(),'Rezoluție')]/following-sibling::span[contains(@class,'value')]");


        public FinishedMonitorAdvPage(CoreChromeDriver driver, IWebElement? categoryButton = null) : base(driver)
        {
            if (categoryButton != null) categoryButton.Click();
        }
    }
}
