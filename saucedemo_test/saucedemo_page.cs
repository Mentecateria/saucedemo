using System;
using System.Threading;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace saucedemo_page
{

    public class saucedemo_test

    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadWebPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Open the testing website
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                
                //Waiting for 4 seconds before closing the browser window
                Thread.Sleep(4000);

            }
        }
    }
}

    public class login
    {
        [Fact]
        [Trait("Category", "Smoke")]

        public void loginData()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Open the testing website  
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");

                //Waiting for 2 seconds 
                Thread.Sleep(2000);
                
                //Find the "Username" field 
                IWebElement username = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/div[1]/input"));
                
                //Fill in the "Username" field
                username.SendKeys("standard_user");
               
                Thread.Sleep(2000);

                 //Find the "Password" field and filling it in 
                 driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/div[2]/input")).SendKeys("secret_sauce");

                Thread.Sleep(2000);
                
                //Click "Login" button
                driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/input")).Click();

               //Waiting for 3 seconds before closing the browser window
                Thread.Sleep(3000);

                


            }

        }

    }
    
    public class addToCart
{
    [Fact]
    [Trait("Category", "Smoke")]
    public void addBackpack()
    {
        using (IWebDriver driver = new ChromeDriver())
        {
            
            //Open the testing website
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            //Waiting for 2 seconds
            Thread.Sleep(2000);

            //Find the "Username" field 
            IWebElement username = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/div[1]/input"));
            
            //Fill in the "Username" field
            username.SendKeys("standard_user");
            
            Thread.Sleep(2000);

            //Find the "Password" field
            IWebElement password = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/div[2]/input"));
            
            //Fill in the "Username" field
            password.SendKeys("secret_sauce");
            
            Thread.Sleep(2000);
            
            //Find and click the "Login" button
            driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/input")).Click();
            
            Thread.Sleep(3000);

            //Find "Add to cart" button at the first item on the page
            IWebElement first_item = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div/div/div[1]/div[2]/div[2]/button"));

            //Click "Add to cart" button
            first_item.Click();
            
            Thread.Sleep(3000);

            //Find a shopping cart icon at the right top corner of the page
            IWebElement cart = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[3]/a"));
            
            //click the cart icon
            cart.Click();

            Thread.Sleep(3000);

            //Find and click the "Checkout" button
            IWebElement checkout = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/button[2]"));
            checkout.Click();
            
            Thread.Sleep(3000);

            //Find the "First name field"
            IWebElement first_name = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[1]/div[1]/input"));
            
            //Fill in the "First name" field
            first_name.SendKeys("John");

            //Find the "Second name field"
            IWebElement second_name = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[1]/div[2]/input"));

            //Fill in the "Second name" field
            second_name.SendKeys("Johnson");

            //Find the "Zip/Postal Code" field
            IWebElement postal_code = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[1]/div[3]/input"));

            //Fill in the "Zip/Postal Code" field
            postal_code.SendKeys("12345");
            
            Thread.Sleep(3000);
            
            //Find and click the "Continue" button
            driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[2]/input")).Click();
            
            Thread.Sleep(2000);

            //Find and click the "Finish" button
            driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[8]/button[2]")).Click();
            Thread.Sleep(5000);

            //Find and click the "Back home" button
            driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/button")).Click();

            //Wait for 5 seconds
            Thread.Sleep(5000);
        }
    }
}



