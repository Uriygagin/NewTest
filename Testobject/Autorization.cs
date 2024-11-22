using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testobject
{
    public class Autorization
    {

        public IWebDriver Driver;

        public Autorization(IWebDriver driver)
        {
            Driver = driver;
        
        }


        public void AutorizationSistem(string name, string password)
        {
            Driver.FindElement(By.XPath("//*[@id = 'user-name']")).SendKeys(name);
            Driver.FindElement(By.XPath("//*[@id = 'password']")).SendKeys(password);
            Driver.FindElement(By.XPath("//*[@id = 'login-button']")).Click();




        }




    }
}
