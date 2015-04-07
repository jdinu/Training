using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
 using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace Project1
{
    public class BaseTestClass
    {

        protected IWebDriver m_driver;



        [SetUp]
        public void setUp()
        {
            m_driver = new FirefoxDriver();
        }

        [TearDown]
        public void tearDown()
        {
            m_driver.Close();
            m_driver.Dispose();


        }
       
        
        //IWebDriver driver new FirefoxDriver(); 
         
        


    }
}
