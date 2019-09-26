using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Instagram_Email_Scrape.Class
{
    class CTunnelbear
    {
        public bool ReConnect(IWebDriver driver)
        {
            try
            {
                var account = File.ReadAllText("tunnel.txt").Split(':');
                try
                {
                    driver.Navigate().GoToUrl("https://www.tunnelbear.com/account#/login");
                    Thread.Sleep(2000);
                    driver.FindElement(By.XPath("//input[@placeholder='Email']")).SendKeys(account[0]);
                    Thread.Sleep(500);
                    driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys(account[1]);
                    Thread.Sleep(500);
                    driver.FindElement(By.XPath("//button[@class='btn btn-lg']")).Click();
                    Thread.Sleep(3000);
                }
                catch (Exception)
                {
                }

                try
                {
                    driver.Navigate().GoToUrl("chrome-extension://agdojnifllhjfhjjhoahodnjpfjjcdgi/html/popup.html");
                    Thread.Sleep(500);

                    driver.FindElement(By.XPath("//span[@class='country-name-span']")).Click();
                    Thread.Sleep(2500);

                    var collection = driver.FindElements(By.XPath("//ul[@id='country-switcher']//li"));
                    int index = new Random().Next(0, collection.Count - 1);
                    collection[index].Click();
                    Thread.Sleep(2000);
                    driver.FindElement(By.XPath("//div[@class='table-cell toggle-cell']")).Click();
                    Thread.Sleep(5000);
                    return true;
                }
                catch (Exception)
                {
                }

            }
            catch (Exception)
            {
            }
            return false;
        }
    }
}
