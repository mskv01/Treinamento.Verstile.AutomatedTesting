using NUnit.Framework;
using System;
using System.Linq;

namespace Treinamento.Versatile.UIAutomatedTesting
{
    public class Teste2cs
    {
        [Test]
        public void Test2()
        {
            string[] nomes = { "Du", "Dudu", "Edu", "Juca", "Mula" };
            //Foreach com Linq
            nomes.ToList().ForEach(name => Console.WriteLine($"Imprimindo nomes pelo foreach: {name}"));

            //Select com linq
            nomes
                .Select(name => name.Contains("du"))
                .ToList()
                .ForEach(isTrue => Console.WriteLine($"O nome contem du? " + isTrue));

            //Where com Linq
            nomes
                .Where(name => name.Contains("Du"))
                .ToList()
                .ForEach(nome => Console.WriteLine($"O nome '{nome}' contem Du"));

            //Any com Linq
            if (nomes.Any(nome => nome.Equals("Juca") || nome.Equals("Mula")))
            {
                Console.WriteLine("Tem Juca ou Mula na lista?");
            }
            //All com linq
            if (nomes.All(nome => nome.Contains("u")))
            {
                Console.WriteLine("Todos os nomes da lista possui a letra 'u'");
            }

            int[] numeros = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(String.Join(", ", numeros.TakeWhile(n => n > 4)));

        }
    }
}





        /* {
            int index = 0;

            //1º ex com array
            string[] nomes = { "Joao", "Maria", "Jose", "Juca" };
            while (index < nomes.Length)
            {
                Console.WriteLine("imprimindo nomes pelo WHILE: " + nomes[index]);
                index++;
            }

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("imprimindo nomes pelo for" + nomes[i]);
            }

            foreach (var nome in nomes)
            {
                Console.WriteLine("imprimindo nomes pelo foreach:" + nome);

            }

            //2º ex com list
            List<int> list = new List<int>();

            index = 1;

            while (index <= 10)
            {
                list.Add(index);
                Console.WriteLine($"Add o número inteiro: '{index}' na list");
                index++;
            }

            for (var i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Imprimindo o numero da lista pelo for: " + list[i]);
            }

            foreach (var numero in list)
            {
                Console.WriteLine("Imprimindo o numero da lista pelo foreach: " + numero);
            }
        }
    }
}*/