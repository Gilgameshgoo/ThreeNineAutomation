using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationCore.CoreTools;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.CoreTools.Elements;

namespace ThreeNineTests.CoreTests.PomPages.ApplicationCategories
{
    public class BasicAddApplication : CoreAutomationPage
    {
        public CoreSelect category => new CoreSelect(FindId("category"));
        public CoreSelect subCategory => new CoreSelect(FindId("subcategory"));
        public CoreSelect regionSelect => FindSelectByLang("Regiune", "Регион");
        public IWebElement price => FindXpath("//dl[contains(.,'Цена') or contains(.,'pre')]//input");
        public CoreSelect currencySelect => new CoreSelect (FindXpath("//select[contains(@class,'price-units')]"));
        public IWebElement applicationTypeSell => FindXpath("//label[contains(text()[2],'Продам') or contains(text()[2],'Vând')]/input");
        public IWebElement applicationTypeBuy => FindXpath("//label[contains(text()[2],'Куплю') or contains(text()[2],'Cumpăr')]/input");
        public IWebElement applicationTitle => FindXpath("//dl[contains(.,'Заголовок') or contains(.,'Titlul') ]//input");
        public IWebElement applicationDescription => FindXpath("//dl[contains(.,'Textul') or contains(.,'Текст') ]//textarea");
        public IWebElement applicationTags => FindXpath("//dl[contains(.,'Tag') or contains(.,'Теги') ]//textarea");
        public IWebElement noPhoneNumberSwitch => FindXpath("//input[contains(@name,'contacts_only_chat')]/following-sibling::i");
        public IWebElement agreeConditions => FindXpath("//input[@name='agree']");
        public IWebElement submitAddButton => FindXpath("//button[contains(@class,'ad-submit')]");
        public IWebElement photoInput => FindId("fileupload-file-input");
        public BasicAddApplication(CoreChromeDriver driver):base(driver) {}

        protected CoreSelect FindSelectByLang(string romanian, string russian)
        {
            return new CoreSelect(FindXpath($"//dl[contains(.,'{romanian}') or contains(.,'{russian}')]//select"));
        }
    }
}
