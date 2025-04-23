using DesafiosPraticos1.PromptSelector;

namespace DesafiosPraticos1.Desafios.FormatoDataAtual;

public class DataPadraoBrasil : IExecutableInterface
{
    public void Execute()
    {
        string dataAtual = DateTime.Now.ToString("dd/MM/yyyy");

        Console.WriteLine(dataAtual);
    }
}
