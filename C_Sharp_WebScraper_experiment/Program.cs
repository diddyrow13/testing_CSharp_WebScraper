using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace C_Sharp_WebScraper_experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://www.google.com");

            ////driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            ////TimeSpan timer = new TimeSpan(0, 0, 5); // hours, min, sec
            ////WebDriverWait wait = new WebDriverWait(driver, timer);



            ////var element = driver.FindElement(By.CssSelector(".nav__categories--browseProducts.js-trigger--browseProducts"));
            ////element.Click();


            ////var element = driver.FindElement(By.XPath("//*[@id=\"tsf\"]/div[2]/div[1]/div[1]/div/div[2]/div"));
            ////element.SendKeys("hello world. this is ya boy");

            //var element = driver.FindElement(By.XPath("//*[@id=\"gbqfbb\"]"));
            ////element.Click();
            ///

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ultimateQa.com/simple-html-elements-for-automation/");

            //IWebElement element = driver.FindElement(By.Id("idExample"));
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"idExample\"]"));
            element.Click();


        }
    }
}
