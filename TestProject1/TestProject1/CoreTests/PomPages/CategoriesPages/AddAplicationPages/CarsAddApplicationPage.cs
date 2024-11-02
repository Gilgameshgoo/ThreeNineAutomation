using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.CoreTools.Elements;

namespace ThreeNineTests.CoreTests.PomPages.ApplicationCategories
{
    public class CarsAddApplicationPage : BasicAddApplication
    {
        public CoreSelect carMakeSelect => FindSelectByLang("Marcă", "Марка");
        public CoreSelect carModelSelect => FindSelectByLang("Model", "Модель");
        public CoreSelect carGenerationSelect => FindSelectByLang("Generație", "Поколение");
        public CoreSelect carRegestrationSelect => FindSelectByLang("Înmatriculare", "Регистрация");
        public CoreSelect carConditionSelect => FindSelectByLang("Stare", "Состояние");
        public CoreSelect carAvailabilitySelect => FindSelectByLang("Disponibilitate", "Наличие");
        public CoreSelect carOriginSelect => FindSelectByLang("Țara de origine", "Происхождение автомобиля");
        public CoreSelect applicationAuthorSelect => FindSelectByLang("Autorul anunțului", "Автор объявления");
        public CoreSelect fabricationYearSelect => FindSelectByLang("An de fabricație", "Год выпуска");
        public CoreSelect bundleSelect => FindSelectByLang("Volan", "Руль");
        public CoreSelect seatsNumberSelect => FindSelectByLang("Număr de locuri", "Количество мест");
        public CoreSelect bodyTypeSelect => FindSelectByLang("Tip caroserie", "Тип кузова");
        public CoreWebelement mileageInput => FindXpath("//dl[contains(.,'Rulaj') or contains(.,'Пробег')]//input");
        public CoreWebelement engineCapacityInput => FindXpath("//dl[contains(.,'Capacitate cilindrică') or contains(.,'Объём двигателя')]//input");
        public CoreSelect fuelTypeSelect => FindSelectByLang("Tip combustibil", "Тип топлива");
        public CoreSelect transmitionTypeSelect => FindSelectByLang("Cutie de viteze", "Кпп");
        public CoreSelect driveTypeSelect => FindSelectByLang("Tip tracțiune", "Привод");


        public CarsAddApplicationPage(CoreChromeDriver driver, IWebElement? categoryButton) : base(driver)
        {
            if (categoryButton != null)  categoryButton.Click();
        }
    }
}
