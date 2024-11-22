using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Testobject
{
   
    public class SetupClass
    {

        public IWebDriver driver;
      



        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(" https://www.saucedemo.com/");

        }


        [TearDown]

        public void TearDown()

        {
            driver.Close();



        }


    }
}