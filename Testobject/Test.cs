using OpenQA.Selenium;

namespace Testobject
{
    public class Test: SetupClass
    {

        [Test]
        public void Test1()
        {
            Autorization autorization = new Autorization(driver);
            CatalogList list = new CatalogList(driver);
            AssertClass assert = new AssertClass(driver);

            autorization.AutorizationSistem("standard_user", "secret_sauce");

            list.InventoryItemClick("Sauce Labs Onesie");
            list.AddToCartInventoryItemClick();
            list.ShoppingCartClick();

            assert.CheckElementNameToShopingCart("Sauce Labs Onesie");



        }
    }
}
    

