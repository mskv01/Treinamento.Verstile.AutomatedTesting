using OpenQA.Selenium;

namespace Treinamento.Versatile.UIAutomatedTesting.Pages
{
    public class RegisterPage
    {
        private IWebDriver webDriver;

        public RegisterPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}