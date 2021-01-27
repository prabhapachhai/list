using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ListLinks
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeTest()
        {
            IWebDriver driver = new ChromeDriver(@"C:\driver\chromedriver_win32");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://demo.guru99.com/test/newtours/";
        }

        [Test]
        public   void Tour()
        {
           // driver.Url = "http://demo.guru99.com/test/newtours/";
            List<string> TextOfAnchors = new List<string>();
            ReadOnlyCollection<IWebElement> AnchorLists = driver.FindElements(By.TagName("a"));
            foreach (IWebElement Anchor in AnchorLists)
            {
                TextOfAnchors.Add(Anchor.Text);

            }
        }

        }
    }
