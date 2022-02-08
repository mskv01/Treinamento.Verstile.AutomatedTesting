using System.Globalization;

namespace Treinamento.Versatile.UIautomatedTesting.Util
{
    public class CalculadorDeIdade
    {
        public static int CalculaIdade(string dataInicio, string dataFim)
        {
            DateTime dateInicio;
            DateTime dateFim;
            int idade;

            dateInicio = DateTime.ParseExact(dataInicio, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (!string.IsNullOrEmpty(dataFim))
            {
                dateFim = DateTime.ParseExact(dataFim, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                idade = dateFim.Year - dateInicio.Year;
            }
            else
            {
                idade = DateTime.Now.Year - dateInicio.Year;
            }
            if (DateTime.Now.DayOfYear < dateInicio.DayOfYear)
            {
                idade --;
            }
            return idade;
        }
    }   
}
