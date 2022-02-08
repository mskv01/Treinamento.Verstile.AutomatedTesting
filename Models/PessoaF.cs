namespace Treinamento.Versatile.UIautomatedTesting.Util
{
    public class PessoaF : Pessoa
    {

        public PessoaF(string nome, string dataInicio, string cpf, string genero, string dataFim = null) : base(nome, dataInicio, dataFim)
        {
            CPF = cpf;
            GENERO = genero;
        }

        public string CPF { get; set; }
        public string GENERO { get; set; }

        public void FalarNome(PessoaF pessoa)
        {
            Console.WriteLine($"Meu nome é {pessoa.Nome}");
        }
        public void FalarCPF(PessoaF pessoa)
        {
            Console.WriteLine($"Meu nome é {pessoa.CPF}");
        }
        public void FalarDiaDeNascimento(PessoaF pessoa)
        {
            Console.WriteLine($"Meu nome é {pessoa.DataInicio}");
        }
        public void FalarGenero(PessoaF pessoa)
        {
            Console.WriteLine($"Meu nome é {pessoa.GENERO}");
        }
        public void FalarIdade(PessoaF pessoa)
        {
          if (string.IsNullOrEmpty(pessoa.DataFim))
            {
                Console.WriteLine($"Tenho {pessoa.Idade} anos de idade");
            }
            else
            {
                Console.WriteLine($"morreu no dia {pessoa.DataFim} com {pessoa.Idade} anos de idade");
            }
        }
    }
}
