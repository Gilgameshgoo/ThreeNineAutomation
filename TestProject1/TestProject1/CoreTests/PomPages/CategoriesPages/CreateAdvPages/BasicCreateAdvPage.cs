using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.CoreTools.Elements;

namespace ThreeNineTests.CoreTests.PomPages.CategoriesPages.CreateAdvPages
{
    public class BasicCreateAdvPage : CoreAutomationPage
    {
        public WebElement title => FindXpath("//header[@class='board__header']");
        public CoreSelect category => new CoreSelect(FindId("category"));
        public CoreSelect subCategory => new CoreSelect(FindId("subcategory"));
        public CoreSelect regionSelect => FindSelectByLang("Regiune", "Регион");
        public IWebElement priceInput => FindXpath("//dl[contains(.,'Цена') or contains(.,'Preț')]//input");
        public CoreSelect currencySelect => new CoreSelect(FindXpath("//select[contains(@class,'price-units')]"));
        public WebElement applicationTypeSell => FindXpath("//label[contains(text()[2],'Продам') or contains(text()[2],'Vând')]/input");
        public WebElement applicationTypeBuy => FindXpath("//label[contains(text()[2],'Куплю') or contains(text()[2],'Cumpăr')]/input");
        public WebElement applicationTitleInput => FindXpath("//dl[contains(.,'Заголовок') or contains(.,'Titlul') ]//input");
        public WebElement applicationDescriptionInput => FindXpath("//dl[contains(.,'Textul') or contains(.,'Текст') ]//textarea");
        public WebElement applicationTagsInput => FindXpath("//dl[contains(.,'Tag') or contains(.,'Теги') ]//textarea");
        public WebElement noPhoneNumberSwitch => FindXpath("//input[contains(@name,'contacts_only_chat')]/following-sibling::i");
        public WebElement agreeConditions => FindXpath("//input[@name='agree']");
        public WebElement submitAddButton => FindXpath("//button[contains(@class,'ad-submit')]");
        public WebElement photo => FindId("fileupload-file-input");
        public WebElement autoRepublishNo => FindXpath("//a[contains(@href,'autorepublish&state=create')]");
        public WebElement autoBoosterNo => FindXpath("//a[contains(@href,'booster&state=create')]");
        public BasicCreateAdvPage(CoreChromeDriver driver) : base(driver) { }

        protected CoreSelect FindSelectByLang(string romanian, string russian)
        {
            return new CoreSelect(FindXpath($"//dl[contains(.,'{romanian}') or contains(.,'{russian}')]//select"));
        }
    }
}
