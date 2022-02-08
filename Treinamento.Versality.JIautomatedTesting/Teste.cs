using NUnit.Framework;
using System;

namespace Treinamento.Versatile.UIAutomatedTesting
{
    public class Teste
    {
        /*Variavel do tipo Char - 1 caracter
        char IncialNomedoMeio = 'C';
        object CharObject = 'C';
        //Variavel do tipo String - vários caracteres
        string Nome = "Marcelo";
        object StringObj = "String Obj";
        //Variavel do tipo Int
        int Idade = 31;
        object IntObj = 1;
        //Variavel do tipo Boolean
        bool EHomem = true;
        object boolObj = false;*/

        /*Variaveis var e object são coringas. Podem receber qualquer valor
           string nomeString = "Marcelo String";
           var nomeVar = "Marcelo Var";

           int numeroInt = 1;
           var numeroVar = 2;
           object numeroobk = 3;

           bool eHomem = true;
           var eMulher = false;
           object eObj = true;*/

        public string Nome = "Juca";
        public int Idade = 31;
        public Boolean eHomem = false;

        public string RetornaStringNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return "O nome não foi informado";
            }
            else if (!string.IsNullOrEmpty(nome) && nome.Equals("Marcelo"))
            {
                return "Marcelo é o seu nome";
            }
            else if (!string.IsNullOrEmpty(nome) && nome.Equals("Jao") || nome.Equals("João"))
            { 
                return "João é o seu nome";
            }
            else
            {
                return "Nome informado é diferente de Marcelo e João ";
            }
        }

        public string RetornaStringGenero(bool genero)
            {
                if (genero == true)
                {
                    return "masculino";
                }
                else
                {
                    return "feminino";
                }
            }

       [Test]
        public void Test1()
        {
            string recebeNome = RetornaStringNome(Nome);
            string recebeGenero = RetornaStringGenero(eHomem);
            Console.WriteLine(recebeNome);
            Console.WriteLine(recebeGenero);
        }
    }
}
