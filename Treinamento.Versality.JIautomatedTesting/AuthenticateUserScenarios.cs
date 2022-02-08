using NUnit.Framework;
using OpenQA.Selenium;
using Treinamento.Versatile.UIAutomatedTesting.Configurations.Factories;
using Treinamento.Versatile.UIAutomatedTesting.Configurations.Helpers;

namespace Treinamento.Versatile.UIAutomatedTesting
{
    public class AuthenticateUserScenarios
    {
        public ActionFactory Actions;
        public User _User;
        public By InputEmail = By.Id("email");
        public By InputSenha = By.Id("senha");
        public By BtnEntrar = By.XPath("//button[contains(text(), 'Entrar')]");
        public By MsgEmailObg = By.Id("//div[contains(text(),'Email é um campo obrigatório')]");
        public By MsgSenhaObg = By.Id("//div[contains(text(),'Senha é um campo obrigatório')]");
        public By MsgInvLogin = By.Id("//div[contains(text(),'Problemas com o login do usuário')]");

        [SetUp]
        public void Init()
        {
            Actions = new ActionFactory();
            Actions._driver = Actions.CreateDriver(Browsers.CHROME);
            Actions.Maximize();
            Actions.Navigate("https://seubarriga.wcaquino.me/login");
            _User = new User();
        }

        [TearDown]
        public void ClearUp() => Actions.Quit();

        [Test]
        public void TC_01ValidarCamposObrigatorios()
        {
            Actions.Click(BtnEntrar);
            Actions.ExistsElement(MsgEmailObg, "No mandatory message was displayed");
            Actions.ExistsElement(MsgSenhaObg, "No mandatory password was displayed");

        }

        [Test]
        public void TC_02ValidarLoginInvalido()
        {
            Actions.SendKeys(InputEmail, _User.InvalidEmail, 30);
            Actions.SendKeys(InputSenha, _User.Password);
            Actions.Click(BtnEntrar);
            Actions.ExistsElement(MsgInvLogin, "Invalid login message was not displayed");

        }

        [Test]

        public void TC_03RealizarLogin()
        {
            Actions.SendKeys(InputEmail, _User.Email);
            Actions.SendKeys(InputSenha, _User.Password);
            Actions.Click(BtnEntrar);
            Actions.ExistsElement(
                By.XPath($"//div[contains(text(), 'Bem vindo, {_User.Name}')]"),
                "An erro ocurred while logging in to the system"
                );
        }

    }
}

