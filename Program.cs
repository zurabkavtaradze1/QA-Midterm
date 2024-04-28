using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;

namespace QA_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var driver = new EdgeDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Navigate().GoToUrl(@"https://magento.softwaretestingboard.com/");
                driver.FindElement(By.Id("ui-id-5")).Click();

                driver.FindElement(By.ClassName("product-item-photo")).Click();

                driver.FindElement(By.Id("option-label-size-143-item-168")).Click();

                driver.FindElement(By.Id("option-label-color-93-item-52")).Click();

                driver.FindElement(By.Id("product-addtocart-button")).Click();

                driver.Navigate().GoToUrl(@"https://magento.softwaretestingboard.com/checkout/#shipping");
            }
        }

    }
}
