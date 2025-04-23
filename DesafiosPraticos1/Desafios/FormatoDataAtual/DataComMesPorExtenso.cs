using System.Globalization;
using DesafiosPraticos1.PromptSelector;

namespace DesafiosPraticos1.Desafios.FormatoDataAtual;

public class DataComMesPorExtenso : IExecutableInterface
{
    public void Execute()
    {
        CultureInfo cultureInfo = new CultureInfo("PT-br");
        DateTime dateTimeAtual = DateTime.Now;

        string dia = dateTimeAtual.ToString("dd", cultureInfo);
        string mes = dateTimeAtual.ToString("MMMM", cultureInfo);
        string ano = dateTimeAtual.ToString("yyyy", cultureInfo);

        Console.WriteLine($"{dia} de {mes} de {ano}");
    }
}
