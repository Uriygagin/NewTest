using OpenQA.Selenium;

namespace Testobject
{
    public class AssertClass
    {
        public IWebDriver Driver;

        public AssertClass(IWebDriver driver)
        {
            Driver = driver;

        }

        public void CheckElementNameToShopingCart(string text)
        {

            Assert.That(Driver.FindElement(By.LinkText(text)).Text.Contains(text));


        }
    }
}