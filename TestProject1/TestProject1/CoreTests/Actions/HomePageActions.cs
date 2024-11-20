using AutomationCore.CoreTools;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.CoreTools.Elements;
using ThreeNineTests.CoreTests.PomPages;
using ThreeNineTests.CoreTests.PomPages.CategoriesPages.CreateAdvPages;

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

        public static T OpenCategory<T>(T addAplicationPage) where T : BasicCreateAdvPage
        {
            Wait.Until(() => addAplicationPage.priceInput.Displayed, TimeSpan.FromSeconds(30));

            return addAplicationPage;
        }

        public static bool AdvNamePresentInFirstFavoriteItem(CoreChromeDriver driver, string advName, HomePage? homePage = null)
        {
            var favoriteListPage = OpenFavoriteList(driver, homePage);

            return favoriteListPage.favoriteItemsListName[0].AssertContains(advName);
        }

        private static FavoriteListPage OpenFavoriteList(CoreChromeDriver driver, HomePage? homePage = null)
        {
            if (homePage == null) { homePage = new HomePage(driver); }

            homePage.personalCabinet.Click();
            Wait.Until(() => homePage.personalCabinetFavoriteList.Click(), TimeSpan.FromSeconds(5));

            var favoriteListPage = new FavoriteListPage(driver);
            //Wait.UntilTrue(() => favoriteListPage.favoriteItemsListNamee[0].Displayed, TimeSpan.FromSeconds(10), 2);
            Wait.UntilTrue(() => favoriteListPage.favoriteItemsListName[0].Displayed, TimeSpan.FromSeconds(10), 2);

            return favoriteListPage;
        }
    }
}
