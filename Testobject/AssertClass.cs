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
        /// <summary>
        /// нахдит по тексту вещь и проверяет что вещь присутствует 
        /// </summary>
        /// <param name="text"></param>
        public void CheckElementNameToShopingCart(string text)
        {
            
            Assert.That(Driver.FindElement(By.LinkText(text)).Text.Contains(text));


        }
    }
}