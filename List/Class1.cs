using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace List
{
    class Class1
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeTest()
        {
            IWebDriver driver = new ChromeDriver(@"C:\driver\chromedriver_win32");
            //driver.Url = "https://www.seleniumeasy.com/test/table-data-download-demo.html";
        }
        [Test]
        public void Collection()
        {
            driver.Url = "https://www.seleniumeasy.com/test/table-data-download-demo.html";
        
        List<string> expectedName = new List<string>()
            {
                "Tiger Nixon",
                "Garrett Winters",
                "Ashton Cox",
                "Cedric Kelly",
                "Airi Satou",
                "Brielle Williamsoa",
                "Herrod Chandler",
                "Rhona Davidson",
                "Colleen Hurst",
                "Sonya Frost",
                "Jena Gaines",
                "Quinn Flynn",
                "Charde Marshall",
                "Haley Kennedy",
                "Tatyana Fitzpatrick",
                "Michael Silva",
                "Paul Byrd",
                "Gloria Little",
                "Bradley Greer",
                "Dai Rios",
                "Jenette Caldwell",
                "Yuri Berry",
                "Caesar Vance",
                "Doris Wilder",
                "Angelica Ramos",
                "Gavin Joyce",
                "Jennifer Chang",
                "Brenden Wagner",
                "Fiona Green",
                "Shou Itou",
                "Michelle House"
            };

            List<string> actualName = new List<string>();
            //List<string> position = new List<string>();
            //List<string> office = new List<string>();
            //List<string> age = new List<string>();
            //List<string> startDate = new List<string>();
            //List<string> salary = new List<string>();

            ReadOnlyCollection<IWebElement> rows = driver.FindElements(By.XPath("//tbody/descendant::tr"));

            for (int i = 1; i <= rows.Count; i++)
            {
                actualName.Add(driver.FindElement(By.XPath("//tbody/descendant::tr[" + i + "]/descendant::td[" + 1 + "]")).Text);
                //position.Add(driver.FindElement(By.XPath("//tbody/descendant::tr[" + i + "]/descendant::td[" + 2 + "]")).Text);
                //office.Add(driver.FindElement(By.XPath("//tbody/descendant::tr[" + i + "]/descendant::td[" + 3 + "]")).Text);
                //age.Add(driver.FindElement(By.XPath("//tbody/descendant::tr[" + i + "]/descendant::td[" + 4 + "]")).Text);
                //startDate.Add(driver.FindElement(By.XPath("//tbody/descendant::tr[" + i + "]/descendant::td[" + 5 + "]")).Text);
                //salary.Add(driver.FindElement(By.XPath("//tbody/descendant::tr[" + i + "]/descendant::td[" + 6 + "]")).Text);
            }
            Assert.AreEqual(expectedName, actualName);
            List<string> possion = new List<string>() { "mina", "prabha", "durga" };
        }
    }
        
    }

