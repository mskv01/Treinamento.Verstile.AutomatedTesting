using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Versatile.UIAutomatedTesting.Configurations.Factories;
using Treinamento.Versatile.UIAutomatedTesting.Configurations.Helpers;

namespace Treinamento.Versatile.UIAutomatedTesting
{
    public class RegisterUserScenarios
    {
        public ActionFactory Actions;
        public User _User;

        [SetUp]
        public void Init()
        {
            Actions = new ActionFactory();
            Actions._driver = Actions.CreateDriver(Browsers.CHROME);
            Actions.Maxime();
            Actions.Navigate("https://seubarriga.wcaquino.me/login");
            _User = new User();
        }

        [TearDown]
        public void ClearUp() => Actions.Quit();
    }
}
