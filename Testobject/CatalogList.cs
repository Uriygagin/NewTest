using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Testobject
{
    internal class CatalogList 
    {

        
        public IWebDriver Driver;

        public CatalogList(IWebDriver driver)
        {
            Driver = driver;

        }
        /// <summary>
        /// ткнуть корзину 
        /// </summary>
        public void ShoppingCartClick()
        {
            Driver.FindElement(By.Id("shopping_cart_container") ).Click();
        }
        /// <summary>
        /// ткнуть фильтр
        /// </summary>
        public void FilterClick()
        {
            Driver.FindElement(By.XPath("//*[@class ='select_container']")).Click();
        }

        /// <summary>
        /// ткнуть на "Добавить велосипедный фонарь"
        /// </summary>
        public void AddToCartSauceLabsBikeLightClick()
        {
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
        }
        /// <summary>
        /// ткнуть меню слева
        /// </summary>
        public void MenuClick()
        {
            Driver.FindElement(By.Id("react-burger-menu-btn")).Click();
        }
        /// <summary>
        /// ткнуть на название придмета 
        /// </summary>
        /// <param name="text"></param>
        public void InventoryItemClick(string text )
        {
            Driver.FindElement(By.LinkText(text)).Click();
        }
        /// <summary>
        /// ткнуть на добавить в корзину внитри придмета 
        /// </summary>
        public void AddToCartInventoryItemClick()
        {
            Driver.FindElement(By.Id("add-to-cart")).Click(); 
        }
    }
}
