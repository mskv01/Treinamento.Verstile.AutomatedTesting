namespace Treinamento.Versatile.UIautomatedTesting.Util
{
    public class PessoaJ : Pessoa

    {
        public PessoaJ(string nome, string dataInicio, string cnpj, string dataFim = null) : base(nome, dataInicio, dataFim)
        {
            CNPJ = cnpj;
        }

        public string CNPJ { get; set; }

        public void FalarNome(PessoaJ pessoa)
        {
            Console.WriteLine($"Meu nome é {pessoa.Nome}");
        }
        public void FalarDiaDeNascimento(PessoaJ pessoa)
        {
            Console.WriteLine($"Meu nome é {pessoa.DataInicio}");
        }
        public void FalarCnpj(PessoaJ pessoa)
        {
            Console.WriteLine($"Meu nome é {pessoa.CNPJ}");
        }
    }
}
