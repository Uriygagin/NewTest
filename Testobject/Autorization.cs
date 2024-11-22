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

        /// <summary>
        /// Заходит под в систему под выбранным пользователем
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public void AutorizationSistem(string name, string password)
        {
            Driver.FindElement(By.XPath("//*[@id = 'user-name']")).SendKeys(name);
            Driver.FindElement(By.XPath("//*[@id = 'password']")).SendKeys(password);
            Driver.FindElement(By.XPath("//*[@id = 'login-button']")).Click();




        }




    }
}
