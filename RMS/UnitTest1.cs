using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Assert = NUnit.Framework.Assert;

namespace RMS
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void A_PatentEntry()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.18.106/RMSSTAGE/Login.aspx");
            driver.Manage().Window.Maximize();
           
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).Click();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).Clear();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).SendKeys("fassv4");
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).Click();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).Clear();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).SendKeys("mubop@123");
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_Button1")).Click();
            Task.Delay(2000).Wait();

            

            IWebElement mnuElement;
            IWebElement submnuElement;
            mnuElement = driver.FindElement(By.LinkText("Patent"));
            submnuElement = driver.FindElement(By.XPath("//a[contains(text(),'Patent Entry')]"));
            Task.Delay(2000).Wait();
            Actions builder = new Actions(driver);
            // Move cursor to the Main Menu Element
            builder.MoveToElement(mnuElement).Perform();
            // Pause 2 Seconds for submenu to be displayed
            Task.Delay(2000).Wait(); //Pause 2 seconds                                     
            submnuElement.Click();// Clicking on the Hidden submnuElement
            Task.Delay(2000).Wait();

            Assert.AreEqual("Patent Entry", driver.FindElement(By.XPath("//div[@id='ctl00_ContentPlaceHolder1_Panel2']/div")).Text);
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ctl00_Label3")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void B_PatentView()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.18.106/RMSSTAGE/Login.aspx");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).Click();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).Clear();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).SendKeys("fassv4");
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).Click();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).Clear();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).SendKeys("mubop@123");
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_Button1")).Click();
            Task.Delay(2000).Wait();



            IWebElement mnuElement;
            IWebElement submnuElement;
            mnuElement = driver.FindElement(By.LinkText("Patent"));
            submnuElement = driver.FindElement(By.XPath("//a[contains(text(),'Patent View')]"));
            Task.Delay(2000).Wait();
            Actions builder = new Actions(driver);
            // Move cursor to the Main Menu Element
            builder.MoveToElement(mnuElement).Perform();
            // Pause 2 Seconds for submenu to be displayed
            Task.Delay(2000).Wait(); //Pause 2 seconds                                     
            submnuElement.Click();// Clicking on the Hidden submnuElement
            Task.Delay(2000).Wait();

            Assert.AreEqual("Patent View", driver.FindElement(By.XPath("//div[contains(text(),'Patent View')]")).Text);
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ctl00_Label3")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

                
        [Test]
        public void C_ProjectReports()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.18.106/RMSSTAGE/Login.aspx");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).Click();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).Clear();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).SendKeys("fassv4");
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).Click();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).Clear();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).SendKeys("mubop@123");
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_Button1")).Click();
            Task.Delay(2000).Wait();

            IWebElement mnuElement;
            IWebElement submnuElement;
            mnuElement = driver.FindElement(By.LinkText("Reports"));
            submnuElement = driver.FindElement(By.XPath("//a[contains(text(),'Project Reports')]"));
            Task.Delay(2000).Wait();
            Actions builder = new Actions(driver);
            // Move cursor to the Main Menu Element
            builder.MoveToElement(mnuElement).Perform();
            // Pause 2 Seconds for submenu to be displayed
            Task.Delay(2000).Wait(); //Pause 2 seconds                                     
            submnuElement.Click();// Clicking on the Hidden submnuElement
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_LinkButton9")).Click();
            Task.Delay(2000).Wait();

            IWebElement selectDate = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxFromDate"));
            selectDate.Click();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_CalendarExtender1_day_1_2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_view")).Click();
            Task.Delay(2000).Wait();

            Assert.AreEqual("Pharmacology                  ", driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[3]/div[3]/center[3]/span[1]/div[1]/table[1]/tbody[1]/tr[5]/td[3]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[2]/td[3]/table[1]/tbody[1]/tr[5]/td[7]/div[1]")).Text);
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ctl00_Label3")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void D_ProjectEntry()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.18.106/RMSSTAGE/Login.aspx");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).Click();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).Clear();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).SendKeys("fassv4");
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).Click();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).Clear();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).SendKeys("mubop@123");
            Task.Delay(1000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_Button1")).Click();
            Task.Delay(2000).Wait();



            IWebElement mnuElement;
            IWebElement submnuElement;
            mnuElement = driver.FindElement(By.LinkText("Project"));
            submnuElement = driver.FindElement(By.XPath("//a[contains(text(),'Project Entry')]"));
            Task.Delay(2000).Wait();
            Actions builder = new Actions(driver);
            // Move cursor to the Main Menu Element
            builder.MoveToElement(mnuElement).Perform();
            // Pause 2 Seconds for submenu to be displayed
            Task.Delay(2000).Wait(); //Pause 2 seconds                                     
            submnuElement.Click();// Clicking on the Hidden submnuElement
            Task.Delay(2000).Wait();

            Assert.AreEqual("Project View", driver.FindElement(By.XPath("//legend[contains(text(),'Existing Project Entry')]")).Text);
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ctl00_Label3")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
    }
}
