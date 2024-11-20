using AutomationCore.CoreTools;
using ThreeNineTests.CoreTests.Data.DataGenerator;
using ThreeNineTests.CoreTests.PomPages.CategoriesPages.CreateAdvPages;

namespace ThreeNineTests.CoreTests.Actions.CategoryActions
{
    public static class TransportCategoryActions
    {
        public static bool CarsAddApplication(CarsCreateAsdvPage carsPage, CarsDataGenerator carData)
        {
            CheckCategoriesSelect(carsPage, carData);

            carsPage.MatchAllSelectElementsByItsName(carsPage, carData);
            carsPage.MatchAllInputElementsByItsName(carsPage, carData);

            carsPage.photo.SendKeys(carData.photo);
            AgreeToConditionsSubmitAplication(carsPage);

            return true;
        }

        private static void AgreeToConditionsSubmitAplication(CarsCreateAsdvPage carsPage)
        {
            carsPage.agreeConditions.Click();
            Wait.UntilTrue(() => carsPage.agreeConditions.GetAttribute("disabled") == null, TimeSpan.FromSeconds(10));

            carsPage.submitAddButton.Click();
        }

        private static void CheckCategoriesSelect(CarsCreateAsdvPage carsPage, CarsDataGenerator carData)
        {
            if (carData.category != null)
                Assert.That(carsPage.category.SelectedOption.Text.Contains(carData.category));

            if (carData.subCategory != null)
                Assert.That(carsPage.subCategory.SelectedOption.Text.Contains(carData.subCategory));
        }
    }
}
