using AutomationCore.CoreTools;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.CoreTools.Elements;
using ThreeNineTests.CoreTests.Data.DataGenerator;
using ThreeNineTests.CoreTests.PomPages.CategoriesPages.CreateAdvPages;
using ThreeNineTests.CoreTests.PomPages.CategoriesPages.FinishedAdvPages;

namespace ThreeNineTests.CoreTests.Actions.CategoryActions
{
    public static class ComputersAndOfficeCategoryActions
    {
        public static FinishedMonitorAdvPage MonitorCreateAdvPage(MonitorCreateAdvPage monitorPage, MonitorDataGenerator monitorData, CoreChromeDriver driver)
        {
            CheckCategoriesSelect(monitorPage, monitorData);

            monitorPage.MatchAllSelectElementsByItsName(monitorPage, monitorData);
            monitorPage.MatchAllInputElementsByItsName(monitorPage, monitorData);

            monitorPage.photo.SendKeys(monitorData.photo);
            monitorPage.noPhoneNumberSwitch.Click();
            AgreeToConditionsSubmitAplication(monitorPage);

            var k = monitorData.regionSelect;
            var ki = monitorData.screenDiagonalSelect;

            Wait.Until(() => monitorPage.autoRepublishNo.Click(), TimeSpan.FromSeconds(10));
            Wait.Until(() => monitorPage.autoBoosterNo.Click(), TimeSpan.FromSeconds(10));

            return new FinishedMonitorAdvPage(driver);
        }

        public static bool MonitorCheckAdvPage(FinishedMonitorAdvPage monitorPage, MonitorDataGenerator monitorData)
        {
            monitorPage.title.AssertContains(monitorData.applicationTitleInput);
            monitorPage.description.AssertContains(monitorData.applicationDescriptionInput);
            monitorPage.manufmanufacturer.AssertContains(monitorData.manufmanufacturerSelect);
            monitorPage.screenDiagonal.AssertContains(monitorData.screenDiagonalSelect);
            monitorPage.screenResolution.AssertContains(monitorData.resolutionSelect);
            monitorPage.price.AssertContains(monitorData.priceInput);
            monitorPage.region.AssertContains(monitorData.regionSelect);

            return true;
        }

        private static void AgreeToConditionsSubmitAplication<T>(T basicPage) where T : BasicCreateAdvPage
        {
            basicPage.agreeConditions.Click();
            Wait.UntilTrue(() => basicPage.submitAddButton.GetAttribute("disabled") == null, TimeSpan.FromSeconds(20));

            basicPage.submitAddButton.Click();
        }

        private static void CheckCategoriesSelect(MonitorCreateAdvPage monitorPage, MonitorDataGenerator monitorData)
        {
            if (monitorData.category != null)
                Assert.That(monitorPage.category.SelectedOption.Text.Contains(monitorData.category));

            if (monitorData.subCategory != null)
                Assert.That(monitorPage.subCategory.SelectedOption.Text.Contains(monitorData.subCategory));
        }
    }
}
