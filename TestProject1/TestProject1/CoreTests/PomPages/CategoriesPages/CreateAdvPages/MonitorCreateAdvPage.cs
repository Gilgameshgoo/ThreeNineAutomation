using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.CoreTools.Elements;

namespace ThreeNineTests.CoreTests.PomPages.CategoriesPages.CreateAdvPages
{
    public class MonitorCreateAdvPage : BasicCreateAdvPage
    {
        public CoreSelect manufmanufacturerSelect => FindSelectByLang("Producător", "Производитель");
        public CoreSelect screenDiagonalSelect => FindSelectByLang("Diagonala ecranului", "Диагональ");
        public CoreSelect resolutionSelect => FindSelectByLang("Rezoluție maximă", "Разрешение");

        public MonitorCreateAdvPage(CoreChromeDriver driver, IWebElement? categoryButton) : base(driver)
        {
            if (categoryButton != null) categoryButton.Click();
        }
    }
}
