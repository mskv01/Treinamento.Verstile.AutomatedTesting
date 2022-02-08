using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Versatile.UIAutomatedTesting.Configurations.Factories
{
    public class DriverFactory
    {
        public IWebDriver _driver;

        public DriverFactory(IWebDriver driver) => _driver = driver;
        
        public IWebDriver CreateDriver(string browser = null)
        {
            browser ??= "chrome";
            switch (browser.ToUpperInvariant())
            {
                case "CHROME":
                    var chromeOptions = new ChromeOptions { PageLoadStrategy = PageLoadStrategy.Eager};
                    return new ChromeDriver(chromeOptions);
                case "FIREFOX":
                    return new FirefoxDriver();
                case "IE":
                    return new InternetExplorerDriver();
                case "EDGE":
                    return new EdgeDriver();

                default:
                    throw new ArgumentException($"Browser não implementado: {browser}");


            }
        }
        public void Navigate(string url) => _driver.Navigate().GoToUrl(url);

        public IWebDriver Driver() => _driver;

        public void Maximize() => _driver.Manage().Window.Maximize();

        public void Refresh() => _driver.Navigate().Refresh();

        public void Close() => _driver.Close();

        public void Quit() => _driver.Quit();
    }
}
