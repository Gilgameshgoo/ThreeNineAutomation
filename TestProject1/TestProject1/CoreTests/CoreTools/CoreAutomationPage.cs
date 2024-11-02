using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.CoreTools.Elements;

namespace AutomationCore.CoreTools
{
    public class CoreAutomationPage
    {
        protected CoreChromeDriver driver;


        public CoreAutomationPage(CoreChromeDriver driver) {
            this.driver = driver;           
        }
        public IWebElement FindElementInFrameSwitch(By by, IWebElement frame) { 
            driver.SwitchTo().Frame(frame);
            var element = driver.FindElement(by);
            driver.SwitchTo().DefaultContent();
            return element;
        }

        protected IWebElement FindId(string id )
        {
            Assert.IsTrue(!id.StartsWith("/"),"Id element looks like Xpath");
            return driver.FindElement(By.Id(id));
        }
        protected CoreWebelement FindXpath(string xpath)
        {
            Assert.IsTrue(xpath.StartsWith("/"), "Erelevant Xpath");
            return driver.FindElement(By.XPath(xpath));
        }

        public void MatchAllSelectElementsByItsName<Z, T>(Z pomPage, T dataClass) where Z: CoreAutomationPage
        {
            foreach (var dataField  in typeof(T).GetFields())
            {
                if (dataField.Name.Contains("Select"))
                {
                    var dataValueField = (string)dataField.GetValue(dataClass);
                    var selectField = (CoreSelect) pomPage.GetType().GetProperty(dataField.Name).GetValue(pomPage);

                    dataField.SetValue(dataClass, selectField.SafeSelectByText(dataValueField, 10));
                    dataValueField = (string)dataField.GetValue(dataClass);
                }

            }
        }

        public void MatchAllШтзгеElementsByItsName<Z, T>(Z pomPage, T dataClass) where Z : CoreAutomationPage
        {
            foreach (var dataField in typeof(T).GetFields())
            {
                if (dataField.Name.Contains("Input"))
                {
                    var dataValueField = (string)dataField.GetValue(dataClass);
                    var inputField = (CoreWebelement)pomPage.GetType().GetProperty(dataField.Name).GetValue(pomPage);

                    inputField.SendKeys(dataValueField);
                }

            }
        }
    }
}
