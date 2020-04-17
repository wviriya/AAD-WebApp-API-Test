using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using Microsoft.Identity.Client;
using System.Threading;

namespace UITests
{
    [TestClass]
    public class WebTest
    {
        // In order to run the below test(s), 
        // please follow the instructions from http://go.microsoft.com/fwlink/?LinkId=619687
        // to install Microsoft WebDriver.

        private IWebDriver _driver;
        private TestContext testContextInstance;
        private string appURL;
        private string browser;
        private string user;
        private string password;
        //private string tenentId;
        //private string clientId;
        //private string clientSecretว

        private AuthenticationResult result;

        public WebTest() { }

        [TestInitialize]
        public void SetupTest()
        {
            appURL = testContextInstance.Properties["appURL"].ToString(); //Environment.GetEnvironmentVariable("appURL");
            browser = testContextInstance.Properties["browser"].ToString(); //Environment.GetEnvironmentVariable("browser");
            user = testContextInstance.Properties["login_user"].ToString(); //Environment.GetEnvironmentVariable("login_user");
            password = testContextInstance.Properties["login_password"].ToString(); //Environment.GetEnvironmentVariable("login_password");
            //tenentId = testContextInstance.Properties["ad_tenentId"].ToString();
            //clientId = testContextInstance.Properties["ad_clientId"].ToString();
            //clientSecret = testContextInstance.Properties["ad_clientSecret"].ToString();
            switch (browser)
            {
                case "Chrome":
                    _driver = new ChromeDriver();
                    break;
                case "Firefox":
                    _driver = new FirefoxDriver();
                    break;
                case "IE":
                    _driver = new InternetExplorerDriver();
                    break;
                case "Edge":
                    _driver = new EdgeDriver();
                    break;
                default:
                    _driver = new ChromeDriver();
                    break;
            }
         }

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        public void Login()
        {

            // Replace with your own test logic
            _driver.Navigate().GoToUrl(appURL);
            _driver.FindElement(By.Id("i0116")).Clear();
            _driver.FindElement(By.Id("i0116")).SendKeys(user);
            _driver.FindElement(By.Id("i0116")).SendKeys(Keys.Enter);
            Thread.Sleep(3000);

            var domObj = _driver.FindElement(By.Id("i0118"));
            if (domObj != null)
            {
                domObj.SendKeys(password);
                domObj.SendKeys(Keys.Enter);
            }
            Thread.Sleep(3000);

            domObj = _driver.FindElement(By.Id("idBtn_Back"));
            if (domObj != null)
            {
                domObj.Click();
            }
        }

        [TestMethod]
        public void VerifyPageTitle()
        {
            Login(); 
            Assert.AreEqual("Home Page - Todo", _driver.Title);
        }

        [TestMethod]
        public void ViewTodoList()
        {
            Login();
            _driver.Navigate().GoToUrl(string.Concat(appURL,"/TodoList"));
            Assert.AreEqual("Index - Todo", _driver.Title);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _driver.Quit();
            _driver?.Dispose();
        }
    }
}
