using System.Globalization;
using DesafiosPraticos1.PromptSelector;

namespace DesafiosPraticos1.Desafios.FormatoDataAtual;

public class DiaMesAnoHoraMinutoSegundos : IExecutableInterface
{
    public void Execute()
    {
        CultureInfo cultureInfo = new CultureInfo("PT-br");
        DateTime dateTimeAtual = DateTime.Now;

        string diaDaSemana = dateTimeAtual.ToString("dddd", cultureInfo);
        string diaDoMes    = dateTimeAtual.ToString("dd", cultureInfo);
        string mes         = dateTimeAtual.ToString("MMMM", cultureInfo);
        string ano         = dateTimeAtual.ToString("yyyy", cultureInfo);
        string time        = dateTimeAtual.ToString("HH:mm:ss", cultureInfo);

        Console.WriteLine($"{diaDaSemana}, {diaDoMes} de {mes} de {ano}, {time}");
    }
}
