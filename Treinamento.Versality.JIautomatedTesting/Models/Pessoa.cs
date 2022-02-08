
namespace Treinamento.Versatile.UIautomatedTesting.Models
{
    public abstract class Pessoa
    {
        public Pessoa(string nome, string dataInicio, string dataFim = null)
        {
            Nome = nome;
            DataInicio = dataInicio;
            Idade = CalculadorDeIdade.CalculaIdade(dataInicio, dataFim);
            DataFim = dataFim;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }


    }
}
