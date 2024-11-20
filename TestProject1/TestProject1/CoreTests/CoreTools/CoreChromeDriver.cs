using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace ThreeNineTests.CoreTests.CoreTools
{
    public class CoreChromeDriver : ChromeDriver
    {
        public IWebElement FindElementInFrame(By by, IWebElement frame)
        {
            SwitchTo().Frame(frame);
            var element = FindElement(by);
            return element;
        }

        public bool SwitchToWindowByTitle(string title)
        {
            foreach (string handle in WindowHandles)
            {
                // Switch to the window
                SwitchTo().Window(handle);

                // Get the title of the current window
                string currentTitle = Title;

                if (currentTitle == title) { return true; }

            }
            throw new NoSuchWindowException();
        }

        public int GetNumberofWindowsByTitle(string title)
        {
            int windowsCount = 0;
            foreach (string handle in WindowHandles)
            {
                // Switch to the window
                SwitchTo().Window(handle);

                // Get the title of the current window
                string currentTitle = Title;

                if (currentTitle == title) { windowsCount++; }

            }
            return windowsCount;
        }

        public new ReadOnlyCollection<WebElement> FindElementss(By by)
        {
            var list = FindElements(by).Cast<WebElement>().ToList();
            //var f = .Cast<WebElement>().ToList()
            return new ReadOnlyCollection<WebElement>(list);
        }
    }
}
