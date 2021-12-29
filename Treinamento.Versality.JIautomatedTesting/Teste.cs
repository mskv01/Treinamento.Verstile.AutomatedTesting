using NUnit.Framework;
using System;

namespace Treinamento.Versatile.UIAutomatedTesting
{
    public class Teste
    {
        //Variavel do tipo Char - 1 caracter
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
        object boolObj = false;

       [Test]
        public void Test1()
        {
            // Variaveis var e object são coringas. Podem receber qualquer valor
            string nomeString = "Marcelo String";
            var nomeVar = "Marcelo Var";

            int numeroInt = 1;
            var numeroVar = 2;
            object numeroobk = 3;
            
            bool eHomem = true;
            var eMulher = false;
            object eObj = true;

            Console.WriteLine($"Olá! Meu nome é {nomeString} e tenho {numeroVar} anos de idade. Am i a man? {eHomem}");
        }
    }
}
