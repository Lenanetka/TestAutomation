using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class Mouse : Element
    {
        public Mouse() : base()
        {
        }
        public void useKeyboard(string keys)
        {
            Actions action = new Actions(driver);
            action.SendKeys(keys).Build().Perform();
        }
        #region byLocator
        public void moveMouseToAndClick(By locator, int x, int y)
        {            
            IWebElement element = waitUntilIsClickable(locator);
            Actions action = new Actions(driver);
            action.MoveToElement(element, x, y).Click().Build().Perform();
        }     
        public void moveMouseTo(By locator)
        {
            IWebElement element = waitUntilIsClickable(locator);
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();
        }
        public void mouseClick(By locator)
        {
            Mouse builder = new Mouse();
            builder.mouseClick(locator);
        }
        public void mouseHoverAndClick(By locator)
        {
            Mouse builder = new Mouse();
            builder.mouseClickAndHold(locator);
        }
        public void mouseDoubleClick(By locator)
        {
            Mouse builder = new Mouse();
            builder.mouseDoubleClick(locator);
        }
        public void mouseClickAndHold(By locator)
        {
            Mouse builder = new Mouse();
            builder.mouseClickAndHold(locator);
        }
        public void dragAndDrop(By locator, int x, int y)
        {
            IWebElement element = waitUntilExists(locator);
            Actions move = new Actions(driver);
            move.DragAndDropToOffset(element, x, y).Build().Perform();
        }
        #endregion
        #region byElement
        public void mouseClick(IWebElement element)
        {
            Mouse builder = new Mouse();
            builder.mouseClick(element);
        }
        public void mouseHoverAndClick(IWebElement element)
        {
            Mouse builder = new Mouse();
            builder.mouseClickAndHold(element);
        }
        public void mouseDoubleClick(IWebElement element)
        {
            Mouse builder = new Mouse();
            builder.mouseDoubleClick(element);
        }
        public void mouseClickAndHold(IWebElement element)
        {
            Mouse builder = new Mouse();
            builder.mouseClickAndHold(element);
        }
        public void mouseDragAndDrop(IWebElement elementFrom, IWebElement elementTo)
        {
            Mouse builder = new Mouse();
            builder.mouseDragAndDrop(elementFrom, elementTo);
        }
        #endregion       
    }
}
