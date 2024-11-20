using AutomationCore.CoreTools;
using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools.Exceptions;

namespace ThreeNineTests.CoreTests.CoreTools.Elements
{
    public static class WebElementExtensions
    {
        public static void ClickJS(this WebElement element)
        {
            ((IJavaScriptExecutor)element.WrappedDriver).ExecuteScript("arguments[0].click();", element);
        }

        public static void SafeSendKeys(this WebElement element, string text, int timeOut)
        {
            Wait.UntilTrue(() =>
            {
                element.SendKeys(text);
                if (!element.GetAttribute("value").Contains(text)) { element.ClickJS(); element.ScrollIntoView(); }
                return element.GetAttribute("value").Contains(text);
            }, TimeSpan.FromSeconds(timeOut));
        }

        public static void ScrollIntoView(this WebElement element)
        {
            ((IJavaScriptExecutor)element.WrappedDriver).ExecuteScript("arguments[0].scrollIntoView(true)", element);
            Thread.Sleep(500);
        }

        public static bool AssertContains(this WebElement element, string expectedText)
        {
            var actualText = element.Text;
            if (!actualText.Contains(expectedText))
            {
                throw new ContainsExpection($"Not Contains. Actual Text: {actualText}; Expected Text: {expectedText}");
            }
            return true;
        }
    }
}
