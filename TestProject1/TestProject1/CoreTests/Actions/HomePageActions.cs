using AutomationCore.CoreTools;
using ThreeNineTests.CoreTests.PomPages;
using ThreeNineTests.CoreTests.CoreTools;

namespace ThreeNineTests.CoreTests.Actions
{
    public static class HomePageActions
    {
        public static ApplicationPage OpenRecomendedItem(CoreChromeDriver driver, HomePage homePage)
        {
            Wait.UntilTrue(() => homePage.recomendedItem.Displayed, TimeSpan.FromSeconds(30));
            var appName = homePage.recomendedItem.Text;
            homePage.recomendedItem.Click();
            Wait.UntilTrue(() => driver.SwitchToWindowByTitle(appName), TimeSpan.FromSeconds(30));              

            return homePage.applicationpage;
        }

        public static CategoriesPage OpenCategoriesMenu(CoreChromeDriver driver, HomePage homePage)
        {
            Wait.Until(() => homePage.addAplication.Click(), TimeSpan.FromSeconds(30));

            var categoriesPage = new CategoriesPage(driver);

            Wait.UntilTrue(() => categoriesPage.baseNode.Displayed, TimeSpan.FromSeconds(30));

            return categoriesPage;
        }
    }
}
