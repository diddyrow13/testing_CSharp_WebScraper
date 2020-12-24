using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace C_Sharp_WebScraper_experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get and validate the budget from the user
            int budget = 0;

            do
            {
                Console.Write("Input budget: $");
                string input = Console.ReadLine();

                try
                {
                    budget = Int32.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\nThe Input was incorrect. Please Retry!");
                }
            } while (budget <= 0);


            // Create driver and neavigate to the page
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.pcpartpicker.com");


            // Naviaget to the "Browse Products" tab and click it
            IWebElement element = driver.FindElement(By.XPath
                ("/html/body/header/nav/div[1]/section[2]/div/ul/li[4]/a"));    // Nav to browse products tab
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; 
            js.ExecuteScript("arguments[0].click();", element);                 // JS click faster than .click() ??
            // element.Click(); // opens browse products tab


            // Go to the CPU section
            element = driver.FindElement(By.XPath
                ("//*[@id=\"navigation\"]/div[4]/div[2]/div/div/div[1]/ul/li[1]/a")); // Nav to CPU element
            //js.ExecuteScript("arguments[0].click();", element);
            element.Click(); // Goes to the list of CPU products

            
        }
    }
}
