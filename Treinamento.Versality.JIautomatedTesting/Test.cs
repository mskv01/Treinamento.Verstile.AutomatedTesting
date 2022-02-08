using NUnit.Framework;
using Treinamento.Versatile.UIAutomatedTesting.Configurations.Factories;

namespace Treinamento.Versatile.UIAutomatedTesting
{
    public class Test
    {
        [Test]  
        public void DriverTest()
        {
            var driver = new DriverFactory();

            driver._driver = driver.CreateDriver();

            driver.Maxime();

            driver.Navigate("https://www.olx.com.br/");

            driver.Quit();

        }
    }
}
