using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Versatile.UIautomatedTesting.Util
{
    public class Testp

    {
        [Test]

        public void Test1()
        {
            //Pessoa Fisica
            var Pessoa1 = new PessoaF("Marcelo Correia Barbosa", "09/07/1990", "000.000.000-00", "Masculino");
            Pessoa1.FalarNome(Pessoa1);
            Pessoa1.FalarDiaDeNascimento(Pessoa1);
            Pessoa1.FalarCPF(Pessoa1);
            Pessoa1.FalarIdade(Pessoa1);
            Pessoa1.FalarGenero(Pessoa1);
        }
    }
}
