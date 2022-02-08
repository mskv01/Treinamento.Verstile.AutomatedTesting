using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Versatile.UIAutomatedTesting.Configurations.Helpers
{
    public class User
    {
        public User ()
        {
            Name = "Marcelo C";
            Email = "fabioaraujo.alves@email.com";
            EmailRegister = "fabioaraujo.alve@email.com" + DateHelper.ReturnDateHours();
            InvalidEmail = "test@invalidlogin.com";
            Password = "123456";

        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string EmailRegister { get; set; }
        public string InvalidEmail { get; set; }
        public string Password { get; set; }
    }
}
