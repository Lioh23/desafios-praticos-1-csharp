using DesafiosPraticos1.PromptSelector;

namespace DesafiosPraticos1.Desafios.FormatoDataAtual;

public class HoraFormato24 : IExecutableInterface
{
    public void Execute()
    {
        Console.WriteLine(DateTime.Now.ToString("HH:mm"));
    }
}
