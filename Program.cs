using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;



namespace Assignment
{
    public class Program
    {
        static IWebDriver driver = new ChromeDriver();
        // static IWebElement dropDownMenu;
        //static IWebElement elementFromTheDropDownMenu;
        // static IWebElement radiobtn;

        static void Main(string[] args)
        {

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
            exericse1();
            exercise2();
            exercise3();
            exercise4();
            exercise4one();
            exericse4two();
            exercise5();
            exercise6(); 
            exercise7();
            exercise8();
            exercise9();






            // Console.WriteLine("Hello World!");
        }

        public static void exericse1()
        {
            IWebElement r1 = driver.FindElement(By.XPath("//input[@value='radio1']"));
            r1.Click();
            if (r1.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The  radio button 1 is checked!");
            }
            else
            {
                Console.WriteLine("This is one of the unchecked radio buttons!");
            }
            Thread.Sleep(3000);

            IWebElement r2 = driver.FindElement(By.XPath("//input[@value='radio2']"));
            r2.Click();
            if (r2.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The  radio button 2 is checked!");
            }
            else
            {
                Console.WriteLine("This is one of the unchecked radio buttons!");
            }
            Thread.Sleep(3000);

            IWebElement r3 = driver.FindElement(By.XPath("//input[@value='radio3']"));
            r3.Click();
            if (r3.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The  radio button 3 is checked!");
            }
            else
            {
                Console.WriteLine("This is one of the unchecked radio buttons!");
            }
            Thread.Sleep(3000);

            //driver.Quit();

        }

        public static void exercise2()  //Not selected
        {

            IWebElement selection = driver.FindElement(By.Id("autocomplete"));
            selection.SendKeys("United");
            IList<IWebElement> sbox = driver.FindElements(By.XPath("//div[@class='ui-menu-item-wrapper']"));

           /* int count = sbox.Count;
            for(int i=0;i<count; i++)
            {
                if (i.Text.Contains("United States (USA)"))
                {
                    i.Click();
                }
            }*/


            foreach (var selement in sbox)
            {
                if (selement.Text.Contains("United States (USA)"))
                {
                    selement.Click();
                }

            }

            Thread.Sleep(2000);
        }

        public static void exercise3()
        {
            IWebElement drop = driver.FindElement(By.Id("dropdown-class-example"));


            SelectElement dropDown = new SelectElement(drop);
            for (int i = 0; i <= 3; i++)
            {
                dropDown.SelectByIndex(i);
                Thread.Sleep(2000);
            }

        }

        public static void exercise4()
        {
            int i = 1;

            do
            {
                IWebElement checkbox = driver.FindElement(By.XPath("//input[@value='option" + i + "']"));
                checkbox.Click();
                Thread.Sleep(2000);
                checkbox.Click();
                i++;
            } while (i <= 3);



        }


        public static void exercise4one()
        {
            for (int j = 1; j <= 3; j++)
            {

                IWebElement checkbox = driver.FindElement(By.XPath("//input[@value='option" + j + "']"));
                checkbox.Click();
                
            }

        }

        public static void exericse4two() 
        {
            Thread.Sleep(2000);
            for (int j = 1; j <= 3; j++)
            {

                IWebElement checkbox = driver.FindElement(By.XPath("//input[@value='option" + j + "']"));
                checkbox.Click();
            }
            Thread.Sleep(3000);
        }

        public static void exercise5()  
        {
            IWebElement openwindow = driver.FindElement(By.Id("openwindow"));
            openwindow.Click();
            Thread.Sleep(2000);


            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);
            // browser.actions().keyDown(protractor.Key.CONTROL).sendKeys('w').perform();

            // IWebElement practicelnk = driver.FindElement(By.XPath("//a[text()='Practice']"));
            // practicelnk.Click();
        }


        public static void exercise6()  //Tab switch
        {
            IWebElement opentabbtn = driver.FindElement(By.Id("opentab"));
            opentabbtn.Click();
            Thread.Sleep(3000);

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);
        }

        public static void exercise7()
        {
            IWebElement alerttxt = driver.FindElement(By.Name("enter-name"));
            alerttxt.SendKeys("Pavana");
            Thread.Sleep(2000);

            IWebElement alertbtn = driver.FindElement(By.Id("alertbtn"));
            alertbtn.Click();
            Thread.Sleep(2000);
            var alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        public static void exercise8()  //Not  understood what to do
        {
            IWebElement element = driver.FindElement(By.Id("product"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();

            Thread.Sleep(2000);
            IList<IWebElement> table = driver.FindElements(By.TagName("td"));

            //int count = table.Count;
            if(table != null && table.Count > 0)
            {
                foreach(var r in table)
                {
                    Console.WriteLine("Not null");
                }
                

            }
            else
                Console.WriteLine("null");

        }

        public static void exercise9()
        {
            IWebElement element = driver.FindElement(By.Id("mousehover"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();


            IWebElement top = driver.FindElement(By.XPath("//a[@href='#top']"));
            actions.MoveToElement(top);
            actions.Perform();
            Thread.Sleep(2000);
            top.Click();

        }
    }
}
