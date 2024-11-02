using AutomationCore.CoreTools;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.PomPages;
using ThreeNineTests.CoreTests.PomPages.ApplicationCategories;

namespace ThreeNineTests.CoreTests.Actions.CategoryActions
{
    public static class CategoryActions
    {
        public static T OpenCategory<T>(T addAplicationPage) where T: BasicAddApplication
        {
            Wait.Until(() => addAplicationPage.price.Displayed, TimeSpan.FromSeconds(30));

            return addAplicationPage;
        }
    }
}
